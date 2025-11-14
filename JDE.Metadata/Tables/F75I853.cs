using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75I853 - .
/// </summary>
public class F75I853 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RGI75TCID.
        /// </summary>
        public const string RGI75TCID = "RGI75TCID";

        /// <summary>
        /// RGDOCO.
        /// </summary>
        public const string RGDOCO = "RGDOCO";

        /// <summary>
        /// RGDCTO.
        /// </summary>
        public const string RGDCTO = "RGDCTO";

        /// <summary>
        /// RGKCOO.
        /// </summary>
        public const string RGKCOO = "RGKCOO";

        /// <summary>
        /// RGLNID.
        /// </summary>
        public const string RGLNID = "RGLNID";

        /// <summary>
        /// RGI75GSTU.
        /// </summary>
        public const string RGI75GSTU = "RGI75GSTU";

        /// <summary>
        /// RGI75BDLU.
        /// </summary>
        public const string RGI75BDLU = "RGI75BDLU";

        /// <summary>
        /// RGI75BLAA.
        /// </summary>
        public const string RGI75BLAA = "RGI75BLAA";

        /// <summary>
        /// RGDEJ.
        /// </summary>
        public const string RGDEJ = "RGDEJ";

        /// <summary>
        /// RGATXA.
        /// </summary>
        public const string RGATXA = "RGATXA";

        /// <summary>
        /// RGI75IGSTA.
        /// </summary>
        public const string RGI75IGSTA = "RGI75IGSTA";

        /// <summary>
        /// RGI75CESSA.
        /// </summary>
        public const string RGI75CESSA = "RGI75CESSA";

        /// <summary>
        /// RGYSTATUS.
        /// </summary>
        public const string RGYSTATUS = "RGYSTATUS";

        /// <summary>
        /// RGI75RECDT.
        /// </summary>
        public const string RGI75RECDT = "RGI75RECDT";

        /// <summary>
        /// RGRMK.
        /// </summary>
        public const string RGRMK = "RGRMK";

        /// <summary>
        /// RGI75CANDT.
        /// </summary>
        public const string RGI75CANDT = "RGI75CANDT";

        /// <summary>
        /// RGICU.
        /// </summary>
        public const string RGICU = "RGICU";

        /// <summary>
        /// RGICUT.
        /// </summary>
        public const string RGICUT = "RGICUT";

        /// <summary>
        /// RGUSER.
        /// </summary>
        public const string RGUSER = "RGUSER";

        /// <summary>
        /// RGPID.
        /// </summary>
        public const string RGPID = "RGPID";

        /// <summary>
        /// RGJOBN.
        /// </summary>
        public const string RGJOBN = "RGJOBN";

        /// <summary>
        /// RGUPMJ.
        /// </summary>
        public const string RGUPMJ = "RGUPMJ";

        /// <summary>
        /// RGUPMT.
        /// </summary>
        public const string RGUPMT = "RGUPMT";

        /// <summary>
        /// RGYFUTDT1.
        /// </summary>
        public const string RGYFUTDT1 = "RGYFUTDT1";

        /// <summary>
        /// RGFUT6.
        /// </summary>
        public const string RGFUT6 = "RGFUT6";

        /// <summary>
        /// RGYT04.
        /// </summary>
        public const string RGYT04 = "RGYT04";

        /// <summary>
        /// RGYFLAG.
        /// </summary>
        public const string RGYFLAG = "RGYFLAG";

        /// <summary>
        /// RGYNUM1.
        /// </summary>
        public const string RGYNUM1 = "RGYNUM1";
    }

    /// <inheritdoc />
    public override string TableName => "F75I853";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RGI75TCID", "RGI75TCID", JdeDataType.Numeric, null, true, true),
        new JdeField("RGDOCO", "RGDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("RGDCTO", "RGDCTO", JdeDataType.String, 4, true, true),
        new JdeField("RGKCOO", "RGKCOO", JdeDataType.String, 10, true, true),
        new JdeField("RGLNID", "RGLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("RGI75GSTU", "RGI75GSTU", JdeDataType.Numeric),
        new JdeField("RGI75BDLU", "RGI75BDLU", JdeDataType.String, 60),
        new JdeField("RGI75BLAA", "RGI75BLAA", JdeDataType.Numeric),
        new JdeField("RGDEJ", "RGDEJ", JdeDataType.Numeric),
        new JdeField("RGATXA", "RGATXA", JdeDataType.Numeric),
        new JdeField("RGI75IGSTA", "RGI75IGSTA", JdeDataType.Numeric),
        new JdeField("RGI75CESSA", "RGI75CESSA", JdeDataType.Numeric),
        new JdeField("RGYSTATUS", "RGYSTATUS", JdeDataType.String, 2),
        new JdeField("RGI75RECDT", "RGI75RECDT", JdeDataType.Numeric),
        new JdeField("RGRMK", "RGRMK", JdeDataType.String, 60),
        new JdeField("RGI75CANDT", "RGI75CANDT", JdeDataType.Numeric),
        new JdeField("RGICU", "RGICU", JdeDataType.Numeric),
        new JdeField("RGICUT", "RGICUT", JdeDataType.String, 4),
        new JdeField("RGUSER", "RGUSER", JdeDataType.String, 20),
        new JdeField("RGPID", "RGPID", JdeDataType.String, 20),
        new JdeField("RGJOBN", "RGJOBN", JdeDataType.String, 20),
        new JdeField("RGUPMJ", "RGUPMJ", JdeDataType.Numeric),
        new JdeField("RGUPMT", "RGUPMT", JdeDataType.Numeric),
        new JdeField("RGYFUTDT1", "RGYFUTDT1", JdeDataType.Numeric),
        new JdeField("RGFUT6", "RGFUT6", JdeDataType.String, 60),
        new JdeField("RGYT04", "RGYT04", JdeDataType.String, 2),
        new JdeField("RGYFLAG", "RGYFLAG", JdeDataType.String, 2),
        new JdeField("RGYNUM1", "RGYNUM1", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75I853_0", "Primary Key on RGI75TCID, RGDOCO, RGDCTO, RGKCOO, RGLNID", new[] { "RGI75TCID", "RGDOCO", "RGDCTO", "RGKCOO", "RGLNID" }, isUnique: true, isPrimaryKey: true)
    };
}
