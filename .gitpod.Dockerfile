FROM gitpod/workspace-full:latest

USER gitpod

# Angular CLI
RUN npm i -g @angular/cli

# .NET Core SDK
RUN mkdir -p /home/gitpod/dotnet && curl -fsSL https://dot.net/v1/dotnet-install.sh | bash /dev/stdin --install-dir /home/gitpod/dotnet
ENV DOTNET_ROOT=/home/gitpod/dotnet
ENV PATH=$PATH:/home/gitpod/dotnet