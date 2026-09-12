export interface MenuItem {
  label?: string;
  href?: string;
  category?: string;
  description?: string;
}
export interface NavLink {
  label: string;
  href?: string;
  subItems?: MenuItem[];
}

export const NAV_LINKS: NavLink[] = [
  {
    label: "Product",
    subItems: [
      { category: "Core" },
      {
        label: "Analytics",
        href: "/product/analytics",
        description: "Real-time insights",
      },
      {
        label: "Billing",
        href: "/product/billing",
        description: "Subscriptions & invoicing",
      },
      {
        label: "Notifications",
        href: "/product/notifications",
        description: "Stay in the loop",
      },
      { category: "Build" },
      {
        label: "Workflow Builder",
        href: "/product/workflow-builder",
        description: "Drag-and-drop automation",
      },
      {
        label: "Custom Fields",
        href: "/product/custom-fields",
        description: "Tailor your data model",
      },
      {
        label: "Webhooks",
        href: "/product/webhooks",
        description: "Real-time events",
      },
      { category: "Scale" },
      {
        label: "SSO",
        href: "/product/sso",
        description: "Enterprise login",
      },
      {
        label: "Roles & Permissions",
        href: "/product/roles",
        description: "Fine-grained access",
      },
      {
        label: "Usage Limits",
        href: "/product/usage",
        description: "Monitor & scale",
      },
    ],
  },
  {
    label: "Company",
    subItems: [
      { category: "Resources" },
      { label: "About", href: "/about", description: "Our mission" },
      { label: "Blogs", href: "/blogs", description: "Latest updates" },
      { category: "Careers" },
      { label: "Careers", href: "/careers", description: "Join us" },
      {
        label: "Open roles",
        href: "/careers/roles",
        description: "Available jobs",
      },
      { category: "Connect" },
      { label: "Contact", href: "/contact", description: "Get in touch" },
      { label: "Press", href: "/press", description: "Media kit" },
    ],
  },
  { label: "Pricing", href: "/pricing" },
];
