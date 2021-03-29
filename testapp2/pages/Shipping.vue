<template>
  <b-container fluid>
    <Logo />
    <h1 class="title">testapplication - E_COM</h1>
    <div class="mt-3">
      <b-button-group>
        <b-button-toolbar key-nav aria-label="Toolbar with button groups">
          <b-button-group class="mx-1">
            <b-button>&lsaquo;</b-button>
          </b-button-group>
          <b-button-group class="mx-1">
            <b-button>&rsaquo;</b-button>
          </b-button-group>
        </b-button-toolbar>
        <b-button variant="info">Account Details</b-button>
        <b-button variant="info">Billing Details</b-button>
        <b-button variant="success">Shipping Details</b-button>
      </b-button-group>
    </div>
    <div></div>
    <b-row v-for="type in types" :key="type" class="my-3">
      <b-col sm="3">
        <label :for="`type-${type}`">
          <code>{{ type }}</code> :</label
        >
      </b-col>
      <b-col sm="5">
        <b-form-input :id="`type-${type}`" :type="type"></b-form-input>
      </b-col>
    </b-row>
    <div></div>
    <div>
      <b-button href="Billing" variant="outline-primary">Back</b-button>
      <b-button variant="outline-primary">Submit</b-button>
    </div>
  </b-container>
  <!-- </div> -->
</template>

<script>
export default {
  data() {
    return {
      types: [
        'Street Address 1',
        'Street Address2',
        'City',
        'District',
        'Specific Registration Request',
        'Would You Like To Recive Our Monthly Mail',
      ],
    }
  },
}
</script>

<style>
.b-container {
  margin-block: 50;
  margin-top: 100px;
  background-color: bisque;
}
.container {
  margin: 0 auto;
  min-height: 100vh;
  display: flex;
  justify-content: center;
  align-items: center;
  text-align: center;
}

.title {
  font-family: 'Quicksand', 'Source Sans Pro', -apple-system, BlinkMacSystemFont,
    'Segoe UI', Roboto, 'Helvetica Neue', Arial, sans-serif;
  display: block;
  font-weight: 300;
  font-size: 100px;
  color: #35495e;
  letter-spacing: 1px;
}

.subtitle {
  font-weight: 300;
  font-size: 42px;
  color: #526488;
  word-spacing: 5px;
  padding-bottom: 15px;
}

.links {
  padding-top: 15px;
}
</style>
