import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: true,
  application: {
    baseUrl,
    name: 'StatePatterns',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44397/',
    redirectUri: baseUrl,
    clientId: 'StatePatterns_App',
    responseType: 'code',
    scope: 'offline_access StatePatterns',
    requireHttps: true
  },
  apis: {
    default: {
      url: 'https://localhost:44397',
      rootNamespace: 'StatePatterns',
    },
  },
} as Environment;
