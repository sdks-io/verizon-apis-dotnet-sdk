// <copyright file="HttpStatusCodeEnum.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace Verizon.Standard.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Verizon.Standard;
    using Verizon.Standard.Utilities;

    /// <summary>
    /// HttpStatusCodeEnum.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum HttpStatusCodeEnum
    {
        /// <summary>
        /// Enum100CONTINUE.
        /// </summary>
        [EnumMember(Value = "100 CONTINUE")]
        Enum100CONTINUE,

        /// <summary>
        /// Enum101SWITCHINGPROTOCOLS.
        /// </summary>
        [EnumMember(Value = "101 SWITCHING_PROTOCOLS")]
        Enum101SWITCHINGPROTOCOLS,

        /// <summary>
        /// Enum102PROCESSING.
        /// </summary>
        [EnumMember(Value = "102 PROCESSING")]
        Enum102PROCESSING,

        /// <summary>
        /// Enum103CHECKPOINT.
        /// </summary>
        [EnumMember(Value = "103 CHECKPOINT")]
        Enum103CHECKPOINT,

        /// <summary>
        /// Enum200OK.
        /// </summary>
        [EnumMember(Value = "200 OK")]
        Enum200OK,

        /// <summary>
        /// Enum201CREATED.
        /// </summary>
        [EnumMember(Value = "201 CREATED")]
        Enum201CREATED,

        /// <summary>
        /// Enum202ACCEPTED.
        /// </summary>
        [EnumMember(Value = "202 ACCEPTED")]
        Enum202ACCEPTED,

        /// <summary>
        /// Enum203NONAUTHORITATIVEINFORMATION.
        /// </summary>
        [EnumMember(Value = "203 NON_AUTHORITATIVE_INFORMATION")]
        Enum203NONAUTHORITATIVEINFORMATION,

        /// <summary>
        /// Enum204NOCONTENT.
        /// </summary>
        [EnumMember(Value = "204 NO_CONTENT")]
        Enum204NOCONTENT,

        /// <summary>
        /// Enum205RESETCONTENT.
        /// </summary>
        [EnumMember(Value = "205 RESET_CONTENT")]
        Enum205RESETCONTENT,

        /// <summary>
        /// Enum206PARTIALCONTENT.
        /// </summary>
        [EnumMember(Value = "206 PARTIAL_CONTENT")]
        Enum206PARTIALCONTENT,

        /// <summary>
        /// Enum207MULTISTATUS.
        /// </summary>
        [EnumMember(Value = "207 MULTI_STATUS")]
        Enum207MULTISTATUS,

        /// <summary>
        /// Enum208ALREADYREPORTED.
        /// </summary>
        [EnumMember(Value = "208 ALREADY_REPORTED")]
        Enum208ALREADYREPORTED,

        /// <summary>
        /// Enum226IMUSED.
        /// </summary>
        [EnumMember(Value = "226 IM_USED")]
        Enum226IMUSED,

        /// <summary>
        /// Enum300MULTIPLECHOICES.
        /// </summary>
        [EnumMember(Value = "300 MULTIPLE_CHOICES")]
        Enum300MULTIPLECHOICES,

        /// <summary>
        /// Enum301MOVEDPERMANENTLY.
        /// </summary>
        [EnumMember(Value = "301 MOVED_PERMANENTLY")]
        Enum301MOVEDPERMANENTLY,

        /// <summary>
        /// Enum302FOUND.
        /// </summary>
        [EnumMember(Value = "302 FOUND")]
        Enum302FOUND,

        /// <summary>
        /// Enum302MOVEDTEMPORARILY.
        /// </summary>
        [EnumMember(Value = "302 MOVED_TEMPORARILY")]
        Enum302MOVEDTEMPORARILY,

        /// <summary>
        /// Enum303SEEOTHER.
        /// </summary>
        [EnumMember(Value = "303 SEE_OTHER")]
        Enum303SEEOTHER,

        /// <summary>
        /// Enum304NOTMODIFIED.
        /// </summary>
        [EnumMember(Value = "304 NOT_MODIFIED")]
        Enum304NOTMODIFIED,

        /// <summary>
        /// Enum305USEPROXY.
        /// </summary>
        [EnumMember(Value = "305 USE_PROXY")]
        Enum305USEPROXY,

        /// <summary>
        /// Enum307TEMPORARYREDIRECT.
        /// </summary>
        [EnumMember(Value = "307 TEMPORARY_REDIRECT")]
        Enum307TEMPORARYREDIRECT,

        /// <summary>
        /// Enum308PERMANENTREDIRECT.
        /// </summary>
        [EnumMember(Value = "308 PERMANENT_REDIRECT")]
        Enum308PERMANENTREDIRECT,

        /// <summary>
        /// Enum400BADREQUEST.
        /// </summary>
        [EnumMember(Value = "400 BAD_REQUEST")]
        Enum400BADREQUEST,

        /// <summary>
        /// Enum401UNAUTHORIZED.
        /// </summary>
        [EnumMember(Value = "401 UNAUTHORIZED")]
        Enum401UNAUTHORIZED,

        /// <summary>
        /// Enum402PAYMENTREQUIRED.
        /// </summary>
        [EnumMember(Value = "402 PAYMENT_REQUIRED")]
        Enum402PAYMENTREQUIRED,

        /// <summary>
        /// Enum403FORBIDDEN.
        /// </summary>
        [EnumMember(Value = "403 FORBIDDEN")]
        Enum403FORBIDDEN,

        /// <summary>
        /// Enum404NOTFOUND.
        /// </summary>
        [EnumMember(Value = "404 NOT_FOUND")]
        Enum404NOTFOUND,

        /// <summary>
        /// Enum405METHODNOTALLOWED.
        /// </summary>
        [EnumMember(Value = "405 METHOD_NOT_ALLOWED")]
        Enum405METHODNOTALLOWED,

        /// <summary>
        /// Enum406NOTACCEPTABLE.
        /// </summary>
        [EnumMember(Value = "406 NOT_ACCEPTABLE")]
        Enum406NOTACCEPTABLE,

        /// <summary>
        /// Enum407PROXYAUTHENTICATIONREQUIRED.
        /// </summary>
        [EnumMember(Value = "407 PROXY_AUTHENTICATION_REQUIRED")]
        Enum407PROXYAUTHENTICATIONREQUIRED,

        /// <summary>
        /// Enum408REQUESTTIMEOUT.
        /// </summary>
        [EnumMember(Value = "408 REQUEST_TIMEOUT")]
        Enum408REQUESTTIMEOUT,

        /// <summary>
        /// Enum409CONFLICT.
        /// </summary>
        [EnumMember(Value = "409 CONFLICT")]
        Enum409CONFLICT,

        /// <summary>
        /// Enum410GONE.
        /// </summary>
        [EnumMember(Value = "410 GONE")]
        Enum410GONE,

        /// <summary>
        /// Enum411LENGTHREQUIRED.
        /// </summary>
        [EnumMember(Value = "411 LENGTH_REQUIRED")]
        Enum411LENGTHREQUIRED,

        /// <summary>
        /// Enum412PRECONDITIONFAILED.
        /// </summary>
        [EnumMember(Value = "412 PRECONDITION_FAILED")]
        Enum412PRECONDITIONFAILED,

        /// <summary>
        /// Enum413PAYLOADTOOLARGE.
        /// </summary>
        [EnumMember(Value = "413 PAYLOAD_TOO_LARGE")]
        Enum413PAYLOADTOOLARGE,

        /// <summary>
        /// Enum413REQUESTENTITYTOOLARGE.
        /// </summary>
        [EnumMember(Value = "413 REQUEST_ENTITY_TOO_LARGE")]
        Enum413REQUESTENTITYTOOLARGE,

        /// <summary>
        /// Enum414URITOOLONG.
        /// </summary>
        [EnumMember(Value = "414 URI_TOO_LONG")]
        Enum414URITOOLONG,

        /// <summary>
        /// Enum414REQUESTURITOOLONG.
        /// </summary>
        [EnumMember(Value = "414 REQUEST_URI_TOO_LONG")]
        Enum414REQUESTURITOOLONG,

        /// <summary>
        /// Enum415UNSUPPORTEDMEDIATYPE.
        /// </summary>
        [EnumMember(Value = "415 UNSUPPORTED_MEDIA_TYPE")]
        Enum415UNSUPPORTEDMEDIATYPE,

        /// <summary>
        /// Enum416REQUESTEDRANGENOTSATISFIABLE.
        /// </summary>
        [EnumMember(Value = "416 REQUESTED_RANGE_NOT_SATISFIABLE")]
        Enum416REQUESTEDRANGENOTSATISFIABLE,

        /// <summary>
        /// Enum417EXPECTATIONFAILED.
        /// </summary>
        [EnumMember(Value = "417 EXPECTATION_FAILED")]
        Enum417EXPECTATIONFAILED,

        /// <summary>
        /// Enum418IAMATEAPOT.
        /// </summary>
        [EnumMember(Value = "418 I_AM_A_TEAPOT")]
        Enum418IAMATEAPOT,

        /// <summary>
        /// Enum419INSUFFICIENTSPACEONRESOURCE.
        /// </summary>
        [EnumMember(Value = "419 INSUFFICIENT_SPACE_ON_RESOURCE")]
        Enum419INSUFFICIENTSPACEONRESOURCE,

        /// <summary>
        /// Enum420METHODFAILURE.
        /// </summary>
        [EnumMember(Value = "420 METHOD_FAILURE")]
        Enum420METHODFAILURE,

        /// <summary>
        /// Enum421DESTINATIONLOCKED.
        /// </summary>
        [EnumMember(Value = "421 DESTINATION_LOCKED")]
        Enum421DESTINATIONLOCKED,

        /// <summary>
        /// Enum422UNPROCESSABLEENTITY.
        /// </summary>
        [EnumMember(Value = "422 UNPROCESSABLE_ENTITY")]
        Enum422UNPROCESSABLEENTITY,

        /// <summary>
        /// Enum423LOCKED.
        /// </summary>
        [EnumMember(Value = "423 LOCKED")]
        Enum423LOCKED,

        /// <summary>
        /// Enum424FAILEDDEPENDENCY.
        /// </summary>
        [EnumMember(Value = "424 FAILED_DEPENDENCY")]
        Enum424FAILEDDEPENDENCY,

        /// <summary>
        /// Enum425TOOEARLY.
        /// </summary>
        [EnumMember(Value = "425 TOO_EARLY")]
        Enum425TOOEARLY,

        /// <summary>
        /// Enum426UPGRADEREQUIRED.
        /// </summary>
        [EnumMember(Value = "426 UPGRADE_REQUIRED")]
        Enum426UPGRADEREQUIRED,

        /// <summary>
        /// Enum428PRECONDITIONREQUIRED.
        /// </summary>
        [EnumMember(Value = "428 PRECONDITION_REQUIRED")]
        Enum428PRECONDITIONREQUIRED,

        /// <summary>
        /// Enum429TOOMANYREQUESTS.
        /// </summary>
        [EnumMember(Value = "429 TOO_MANY_REQUESTS")]
        Enum429TOOMANYREQUESTS,

        /// <summary>
        /// Enum431REQUESTHEADERFIELDSTOOLARGE.
        /// </summary>
        [EnumMember(Value = "431 REQUEST_HEADER_FIELDS_TOO_LARGE")]
        Enum431REQUESTHEADERFIELDSTOOLARGE,

        /// <summary>
        /// Enum451UNAVAILABLEFORLEGALREASONS.
        /// </summary>
        [EnumMember(Value = "451 UNAVAILABLE_FOR_LEGAL_REASONS")]
        Enum451UNAVAILABLEFORLEGALREASONS,

        /// <summary>
        /// Enum500INTERNALSERVERERROR.
        /// </summary>
        [EnumMember(Value = "500 INTERNAL_SERVER_ERROR")]
        Enum500INTERNALSERVERERROR,

        /// <summary>
        /// Enum501NOTIMPLEMENTED.
        /// </summary>
        [EnumMember(Value = "501 NOT_IMPLEMENTED")]
        Enum501NOTIMPLEMENTED,

        /// <summary>
        /// Enum502BADGATEWAY.
        /// </summary>
        [EnumMember(Value = "502 BAD_GATEWAY")]
        Enum502BADGATEWAY,

        /// <summary>
        /// Enum503SERVICEUNAVAILABLE.
        /// </summary>
        [EnumMember(Value = "503 SERVICE_UNAVAILABLE")]
        Enum503SERVICEUNAVAILABLE,

        /// <summary>
        /// Enum504GATEWAYTIMEOUT.
        /// </summary>
        [EnumMember(Value = "504 GATEWAY_TIMEOUT")]
        Enum504GATEWAYTIMEOUT,

        /// <summary>
        /// Enum505HTTPVERSIONNOTSUPPORTED.
        /// </summary>
        [EnumMember(Value = "505 HTTP_VERSION_NOT_SUPPORTED")]
        Enum505HTTPVERSIONNOTSUPPORTED,

        /// <summary>
        /// Enum506VARIANTALSONEGOTIATES.
        /// </summary>
        [EnumMember(Value = "506 VARIANT_ALSO_NEGOTIATES")]
        Enum506VARIANTALSONEGOTIATES,

        /// <summary>
        /// Enum507INSUFFICIENTSTORAGE.
        /// </summary>
        [EnumMember(Value = "507 INSUFFICIENT_STORAGE")]
        Enum507INSUFFICIENTSTORAGE,

        /// <summary>
        /// Enum508LOOPDETECTED.
        /// </summary>
        [EnumMember(Value = "508 LOOP_DETECTED")]
        Enum508LOOPDETECTED,

        /// <summary>
        /// Enum509BANDWIDTHLIMITEXCEEDED.
        /// </summary>
        [EnumMember(Value = "509 BANDWIDTH_LIMIT_EXCEEDED")]
        Enum509BANDWIDTHLIMITEXCEEDED,

        /// <summary>
        /// Enum510NOTEXTENDED.
        /// </summary>
        [EnumMember(Value = "510 NOT_EXTENDED")]
        Enum510NOTEXTENDED,

        /// <summary>
        /// Enum511NETWORKAUTHENTICATIONREQUIRED.
        /// </summary>
        [EnumMember(Value = "511 NETWORK_AUTHENTICATION_REQUIRED")]
        Enum511NETWORKAUTHENTICATIONREQUIRED
    }
}