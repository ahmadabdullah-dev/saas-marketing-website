import { Box, Typography } from "@mui/material";
import AppLogoWithName from "../AppLogoWithName";

export default function TemporaryDrawerFooter() {
  return (
    <Box
      sx={{
        display: "flex",
        alignItems: "center",
        flexWrap: "wrap",
      }}
    >
      <Typography
        variant="caption"
        sx={{ whiteSpace: "nowrap", color: "text.secondary" }}
      >
        © {new Date().getFullYear()}
      </Typography>

      <AppLogoWithName />

      <Typography
        variant="caption"
        sx={{ whiteSpace: "nowrap", color: "text.secondary" }}
      >
        All rights reserved.
      </Typography>
    </Box>
  );
}
