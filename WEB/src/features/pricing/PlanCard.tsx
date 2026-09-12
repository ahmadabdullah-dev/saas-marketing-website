import {
  Box,
  Typography,
  Button,
  Chip,
  List,
  ListItem,
  ListItemIcon,
  ListItemText,
} from "@mui/material";
import CheckIcon from "@mui/icons-material/Check";

interface Plan {
  id: string;
  name: string;
  tagline: string;
  price: string;
  priceSub: string;
  cta: string;
  highlight: boolean;
  features: string[];
}

interface PlanCardProps {
  plan: Plan;
}

export default function PlanCard({ plan }: PlanCardProps) {
  const { name, tagline, price, priceSub, cta, highlight, features } = plan;

  return (
    <Box
      sx={{
        position: "relative",
        display: "flex",
        flexDirection: "column",
        flex: 1,
        minWidth: 140,
        border: "1px solid",
        borderColor: highlight ? "primary.main" : "divider",
        bgcolor: "background.paper",
        p: 4,
        transition: "border-color 160ms ease, transform 160ms ease",
        "&:hover": {
          borderColor: "primary.main",
        },
      }}
    >
      {highlight && (
        <Chip
          label="Most popular"
          size="small"
          sx={{
            position: "absolute",
            top: 0,
            right: 0,
            transform: "translateY(-50%)",
            bgcolor: "secondary.main",
            color: "primary.main",
            borderRadius: 0,
            fontWeight: 600,
            fontSize: "0.6875rem",
            letterSpacing: "0.06em",
            textTransform: "uppercase",
            height: 24,
          }}
        />
      )}

      <Typography
        variant="overline"
        sx={{
          color: "text.secondary",
          letterSpacing: "0.08em",
          fontSize: "0.75rem",
        }}
      >
        {name}
      </Typography>

      <Typography
        sx={{
          mt: 0.5,
          mb: 1.5,
          color: "text.secondary",
          fontSize: "0.875rem",
          lineHeight: 1.5,
          minHeight: "2.6em",
        }}
      >
        {tagline}
      </Typography>

      <Box sx={{ display: "flex", alignItems: "baseline", gap: 1, mb: 3 }}>
        <Typography
          sx={{
            fontWeight: 700,
            fontSize: "2.75rem",
            lineHeight: 1,
            fontFamily: "inherit",
          }}
        >
          {price}
        </Typography>
        <Typography sx={{ color: "text.secondary", fontSize: "0.875rem" }}>
          {priceSub}
        </Typography>
      </Box>

      <Box sx={{ borderTop: "1px solid", borderColor: "divider", mb: 3 }} />

      <List dense disablePadding sx={{ mb: 3 }}>
        {features.map((feature) => (
          <ListItem
            key={feature}
            disableGutters
            disablePadding
            sx={{ py: 0.5 }}
          >
            <ListItemIcon sx={{ minWidth: 28 }}>
              <CheckIcon
                fontSize="small"
                sx={{ color: highlight ? "primary.main" : "text.secondary" }}
              />
            </ListItemIcon>
            <ListItemText
              primary={feature}
            />
          </ListItem>
        ))}
      </List>

      <Box sx={{ flexGrow: 1 }} />

      <Button
        fullWidth
        variant={highlight ? "contained" : "outlined"}
        color={highlight ? "primary" : "inherit"}
        sx={{
          borderColor: highlight ? undefined : "divider",
          color: highlight ? undefined : "text.primary",
          "&:hover": {
            borderColor: highlight ? undefined : "text.primary",
            bgcolor: highlight ? undefined : "rgba(255,255,255,0.04)",
          },
        }}
      >
        {cta}
      </Button>
    </Box>
  );
}
