using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75I836 - .
/// </summary>
public class F75I836 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RSKCOO.
        /// </summary>
        public const string RSKCOO = "RSKCOO";

        /// <summary>
        /// RSDOCO.
        /// </summary>
        public const string RSDOCO = "RSDOCO";

        /// <summary>
        /// RSDCTO.
        /// </summary>
        public const string RSDCTO = "RSDCTO";

        /// <summary>
        /// RSLNID.
        /// </summary>
        public const string RSLNID = "RSLNID";

        /// <summary>
        /// RSDOC.
        /// </summary>
        public const string RSDOC = "RSDOC";

        /// <summary>
        /// RSDCT.
        /// </summary>
        public const string RSDCT = "RSDCT";

        /// <summary>
        /// RSI75RSNC.
        /// </summary>
        public const string RSI75RSNC = "RSI75RSNC";

        /// <summary>
        /// RSI75RMRK.
        /// </summary>
        public const string RSI75RMRK = "RSI75RMRK";

        /// <summary>
        /// RSLITM.
        /// </summary>
        public const string RSLITM = "RSLITM";

        /// <summary>
        /// RSITM.
        /// </summary>
        public const string RSITM = "RSITM";

        /// <summary>
        /// RSMCU.
        /// </summary>
        public const string RSMCU = "RSMCU";

        /// <summary>
        /// RSLOCN.
        /// </summary>
        public const string RSLOCN = "RSLOCN";

        /// <summary>
        /// RSLOTN.
        /// </summary>
        public const string RSLOTN = "RSLOTN";

        /// <summary>
        /// RSAN8.
        /// </summary>
        public const string RSAN8 = "RSAN8";

        /// <summary>
        /// RSSOQS.
        /// </summary>
        public const string RSSOQS = "RSSOQS";

        /// <summary>
        /// RSUOM.
        /// </summary>
        public const string RSUOM = "RSUOM";

        /// <summary>
        /// RSDGL.
        /// </summary>
        public const string RSDGL = "RSDGL";

        /// <summary>
        /// RSUSER.
        /// </summary>
        public const string RSUSER = "RSUSER";

        /// <summary>
        /// RSPID.
        /// </summary>
        public const string RSPID = "RSPID";

        /// <summary>
        /// RSJOBN.
        /// </summary>
        public const string RSJOBN = "RSJOBN";

        /// <summary>
        /// RSUPMJ.
        /// </summary>
        public const string RSUPMJ = "RSUPMJ";

        /// <summary>
        /// RSUPMT.
        /// </summary>
        public const string RSUPMT = "RSUPMT";

        /// <summary>
        /// RSYFUTDT1.
        /// </summary>
        public const string RSYFUTDT1 = "RSYFUTDT1";

        /// <summary>
        /// RSFUT6.
        /// </summary>
        public const string RSFUT6 = "RSFUT6";

        /// <summary>
        /// RSYT04.
        /// </summary>
        public const string RSYT04 = "RSYT04";

        /// <summary>
        /// RSYFLAG.
        /// </summary>
        public const string RSYFLAG = "RSYFLAG";

        /// <summary>
        /// RSYNUM1.
        /// </summary>
        public const string RSYNUM1 = "RSYNUM1";
    }

    /// <inheritdoc />
    public override string TableName => "F75I836";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RSKCOO", "RSKCOO", JdeDataType.String, 10, true, true),
        new JdeField("RSDOCO", "RSDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("RSDCTO", "RSDCTO", JdeDataType.String, 4, true, true),
        new JdeField("RSLNID", "RSLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("RSDOC", "RSDOC", JdeDataType.Numeric),
        new JdeField("RSDCT", "RSDCT", JdeDataType.String, 4),
        new JdeField("RSI75RSNC", "RSI75RSNC", JdeDataType.String, 10),
        new JdeField("RSI75RMRK", "RSI75RMRK", JdeDataType.String, 120),
        new JdeField("RSLITM", "RSLITM", JdeDataType.String, 50),
        new JdeField("RSITM", "RSITM", JdeDataType.Numeric),
        new JdeField("RSMCU", "RSMCU", JdeDataType.String, 24),
        new JdeField("RSLOCN", "RSLOCN", JdeDataType.String, 40),
        new JdeField("RSLOTN", "RSLOTN", JdeDataType.String, 60),
        new JdeField("RSAN8", "RSAN8", JdeDataType.Numeric),
        new JdeField("RSSOQS", "RSSOQS", JdeDataType.Numeric),
        new JdeField("RSUOM", "RSUOM", JdeDataType.String, 4),
        new JdeField("RSDGL", "RSDGL", JdeDataType.Numeric),
        new JdeField("RSUSER", "RSUSER", JdeDataType.String, 20),
        new JdeField("RSPID", "RSPID", JdeDataType.String, 20),
        new JdeField("RSJOBN", "RSJOBN", JdeDataType.String, 20),
        new JdeField("RSUPMJ", "RSUPMJ", JdeDataType.Numeric),
        new JdeField("RSUPMT", "RSUPMT", JdeDataType.Numeric),
        new JdeField("RSYFUTDT1", "RSYFUTDT1", JdeDataType.Numeric),
        new JdeField("RSFUT6", "RSFUT6", JdeDataType.String, 60),
        new JdeField("RSYT04", "RSYT04", JdeDataType.String, 2),
        new JdeField("RSYFLAG", "RSYFLAG", JdeDataType.String, 2),
        new JdeField("RSYNUM1", "RSYNUM1", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75I836_0", "Primary Key on RSKCOO, RSDOCO, RSDCTO, RSLNID", new[] { "RSKCOO", "RSDOCO", "RSDCTO", "RSLNID" }, isUnique: true, isPrimaryKey: true)
    };
}
