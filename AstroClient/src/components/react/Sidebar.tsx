import React, { useState } from 'react';
import { Accordion, AccordionItem, Divider } from '@nextui-org/react';
import { Icon } from '@iconify/react';

interface SubOption {
  name: string;
  icon: string;
  path?: string;
}

interface Option {
  name: string;
  icon: string;
  subOptions: SubOption[];
}

interface SidebarProps {
  logoSrc: string;
  options: Option[];
}

const Sidebar: React.FC<SidebarProps> = ({ logoSrc, options }) => {
  const [expandedIndex, setExpandedIndex] = useState<number | null>(null);

  const handleToggle = (index: number) => {
    setExpandedIndex(expandedIndex === index ? null : index);
  };

  return (
    <div className="w-64 h-full bg-background text-text flex flex-col">
      <div className="p-4 text-center">
        <img src={logoSrc} alt="Logo" />
      </div>
      <div className="flex-1 overflow-y-auto">
        <a href="/" className="block py-2 px-5">
          <div className="flex items-center">
            <Icon icon="tabler:home-2" className="mr-2 icon-large" fontSize="18" />
            <span className="text-large">Home</span>
          </div>
        </a>
        <div className="flex items-center block p-2 ">
          <Divider className="my-4" />
        </div>
        <Accordion>
          {options.map((option, index) => (
            <AccordionItem
              key={index}
              title={
                <div className="flex items-center px-2">
                  <Icon icon={option.icon} className="mr-2 icon-large" fontSize="18" />
                  <span className="text-large">{option.name}</span>
                </div>
              }
              textValue={option.name}
            >
              {option.subOptions && (
                <div className="ml-4 mt-2">
                  {option.subOptions.map((subOption, subIndex) => (
                    <a href={subOption.path || '#'} key={subIndex} className="block">
                      <div className="p-2 hover:bg-hornet-500 flex items-center cursor-pointer">
                        <Icon icon={subOption.icon} className="mr-2 icon-large" />
                        <span className="text-large">{subOption.name}</span>
                      </div>
                    </a>
                  ))}
                </div>
              )}
            </AccordionItem>
          ))}
        </Accordion>
      </div>
    </div>
  );
};

export default Sidebar;