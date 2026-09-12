import { Box, Stack, Typography } from "@mui/material";
import PlanCard from "./PlanCard";
import { PLANS } from "./plans";
import {Grid} from "@mui/material";
export default function PricingTable() {
  return (
    <Box
      sx={{
        bgcolor: "background.default",
        color: "text.primary",
        py: { xs: 6, md: 10 },
        px: { xs: 3, md: 6 },
      }}
    >
      <Stack spacing={1.5} sx={{ mb: 6, maxWidth: 640 }}>
        <Typography
          variant="h2"
          sx={{ fontSize: { xs: "2rem", md: "2.5rem" } }}
        >
          Pricing
        </Typography>
        <Typography sx={{ color: "text.secondary", fontSize: "1rem" }}>
          Simple plans that grow with your team. No hidden fees.
        </Typography>
      </Stack>
    
      <Grid container spacing={{ xs: 3, md: 2 }}>
        {PLANS.map((plan) => (
          <Grid size={{ xs: 12, sm: 6, md: 3 }} key={plan.id}>
            <PlanCard plan={plan} />
          </Grid>
        ))}
      </Grid>
    </Box>
  );
}
