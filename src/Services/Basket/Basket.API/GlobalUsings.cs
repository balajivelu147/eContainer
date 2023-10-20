﻿global using System.ComponentModel.DataAnnotations;
global using System.Security.Claims;
global using System.Text.Json;
global using Basket.API.IntegrationEvents.EventHandling;
global using Basket.API.IntegrationEvents.Events;
global using Basket.API.Model;
global using Basket.API.Repositories;
global using Grpc.Core;
global using GrpcBasket;
global using Microsoft.AspNetCore.Authorization;
global using Microsoft.AspNetCore.Mvc;
global using Microsoft.MPGC.BuildingBlocks.EventBus.Abstractions;
global using Microsoft.MPGC.BuildingBlocks.EventBus.Events;
global using Microsoft.MPGC.Services.Basket.API.IntegrationEvents.EventHandling;
global using Microsoft.MPGC.Services.Basket.API.IntegrationEvents.Events;
global using Microsoft.MPGC.Services.Basket.API.Model;
global using Microsoft.MPGC.Services.Basket.API.Services;
global using Services.Common;
global using StackExchange.Redis;
