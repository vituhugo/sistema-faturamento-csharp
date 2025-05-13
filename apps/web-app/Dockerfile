# Use alpine node base image
FROM node:22-alpine as builder

# Set working directory inside the docker node
WORKDIR /app

# Copy package files and install dependencies
COPY ./package*.json ./
RUN npm install

# Copy the rest of the application code
COPY ./ ./
RUN npm run build

RUN npm install --omit=dev

FROM nginx:alpine

WORKDIR /app

COPY --from=builder /app/dist/web-app/browser /usr/share/nginx/html
CMD ["nginx", "-g", "daemon off;"]
