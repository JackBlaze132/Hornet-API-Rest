<script>
  import Icon from '@iconify/svelte';

  export let logo;
  export let options = [];

  let expandedIndex = null;

  function toggle(index) {
    expandedIndex = expandedIndex === index ? null : index;
  }
</script>

<style>
  .accordion-content {
    overflow: hidden;
    max-height: 0;
    opacity: 0;
    transition: max-height 0.3s ease, opacity 0.3s ease;
  }

  .accordion-content.expanded {
    max-height: 500px; /* Ajusta este valor según el contenido */
    opacity: 1;
  }

  .accordion-item {
    transition: background-color 0.3s ease;
  }

  .accordion-item.expanded,
  .accordion-item:hover {
    background-color: #4a5568; /* Color del hover */
  }

  .icon-large {
    font-size: 1.5rem; /* Ajusta el tamaño del icono */
  }

  .text-large {
    font-size: 1.2rem; /* Ajusta el tamaño del texto */
  }
</style>

<div class="h-screen w-64 bg-gray-800 text-white flex flex-col">
  <!-- Logo -->
  <div class="p-4">
    <img src={logo} alt="Logo"/>
  </div>
  
  <!-- Options -->
  <nav class="flex-1">
    <a href="/">
    <div class="p-4 hover:bg-gray-700 cursor-pointer">
      <div class="flex items-center">
        <Icon icon="tabler:home-2" class="mr-2 icon-large" font-size="18"></Icon>
        <span class="text-large">Home</span>
      </div>
    </div>
  </a>
    <div class="p-4 hover:bg-gray-700">
      <hr class="border-t border-gray-600 my-2" />
    </div>
    
    {#each options as option, index}
      <div class="p-4 cursor-pointer accordion-item {expandedIndex === index ? 'expanded' : ''}" on:click={() => toggle(index)}>
        <div class="flex items-center">
          <Icon icon={option.icon} class="mr-2 icon-large" font-size="18"/>
          <span class="text-large">{option.name}</span>
        </div>
        <div class="accordion-content {expandedIndex === index ? 'expanded' : ''}">
          {#if expandedIndex === index}
            {#if option.subOptions}
              <div class="ml-4 mt-2">
                {#each option.subOptions as subOption}
                  <a href={subOption.path}>
                    <div class="p-2 hover:bg-gray-600 flex items-center cursor-pointer">
                      <Icon icon={subOption.icon} class="mr-2 icon-large" />
                      <span class="text-large">{subOption.name}</span>
                    </div>
                  </a>
                {/each}
              </div>
            {/if}
          {/if}
        </div>
      </div>
    {/each}
  </nav>
</div>