# Concept and setup
- In this IaC field, the most popular tool at the moment is probably Terraform. Terraform is an open-source of HashiCorp, specialized in provisioning infrastructure, we just need to write code, then type a few simple CLI sentences, it will create Infrastructure for us, instead of us going to the web console to click, which is very time-consuming.
https://learn.microsoft.com/en-us/azure/developer/terraform/overview 

- Using Terraform, you create configuration files using HCL syntax. The HCL syntax allows you to specify the cloud provider - such as Azure - and the elements that make up your cloud infrastructure

# How to run
- Go to specifict directory and run some commands below: 

    ```terraform init -upgrade```

    ```terraform plan -out main.tfplan```

    ```terraform apply main.tfplan```

    ```terraform plan -destroy -out main.destroy.tfplan``` // For clean up resources

    ```terraform apply main.destroy.tfplan```

- Explaination: https://learn.microsoft.com/en-us/azure/developer/terraform/create-resource-group?tabs=azure-cli