export const SITE = {
  title: "Hornet API Rest",
  description: "Hornet Consair Software.",
  defaultLanguage: "en_US",
  twitter: "@astro",
  github: "JackBlaze132/Hornet-API-Rest",
  linkedin: "jhon-cardenas",
};

export const OPEN_GRAPH = {
  image: {
    src: "",
    alt: "",
  },
  twitter: "",
};

export const SIDEBAR = [
  { text: "Motorcycle", header: true },
  { text: "Add", link: "/core/introduction" },
  { text: "Edit", link: "/core/colors" },
  { text: "Delete", link: "/core/typography" },
  { text: "Get", link: "/components/table"},

  { text: "Automobiles", header: true },
  { text: "Add", link: "/components/buttons" },
  { text: "Edit", link: "/components/input" },
  { text: "Delete", link: "/components/status-pill" },
  { text: "Get", link: "/components/getAuto" },

  { text: "Bodyworks", header: true },
  { text: "Add", link: "/patterns/addBody" },
  { text: "Delete", link: "/patterns/introduction" },
  { text: "Get", link: "/components/table" },
];
