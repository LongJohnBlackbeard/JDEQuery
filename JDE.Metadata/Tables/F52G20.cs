using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F52G20 - .
/// </summary>
public class F52G20 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// LCDOCO.
        /// </summary>
        public const string LCDOCO = "LCDOCO";

        /// <summary>
        /// LCDCTO.
        /// </summary>
        public const string LCDCTO = "LCDCTO";

        /// <summary>
        /// LCKCOO.
        /// </summary>
        public const string LCKCOO = "LCKCOO";

        /// <summary>
        /// LCMCU.
        /// </summary>
        public const string LCMCU = "LCMCU";

        /// <summary>
        /// LCJBCD.
        /// </summary>
        public const string LCJBCD = "LCJBCD";

        /// <summary>
        /// LCDESC.
        /// </summary>
        public const string LCDESC = "LCDESC";

        /// <summary>
        /// LCLBRTY.
        /// </summary>
        public const string LCLBRTY = "LCLBRTY";

        /// <summary>
        /// LCCTF1.
        /// </summary>
        public const string LCCTF1 = "LCCTF1";

        /// <summary>
        /// LCFEEC.
        /// </summary>
        public const string LCFEEC = "LCFEEC";

        /// <summary>
        /// LCLOEHRS.
        /// </summary>
        public const string LCLOEHRS = "LCLOEHRS";

        /// <summary>
        /// LCFRTYP.
        /// </summary>
        public const string LCFRTYP = "LCFRTYP";

        /// <summary>
        /// LCFEERT.
        /// </summary>
        public const string LCFEERT = "LCFEERT";

        /// <summary>
        /// LCPID.
        /// </summary>
        public const string LCPID = "LCPID";

        /// <summary>
        /// LCJOBN.
        /// </summary>
        public const string LCJOBN = "LCJOBN";

        /// <summary>
        /// LCUSER.
        /// </summary>
        public const string LCUSER = "LCUSER";

        /// <summary>
        /// LCUPMJ.
        /// </summary>
        public const string LCUPMJ = "LCUPMJ";

        /// <summary>
        /// LCUPMT.
        /// </summary>
        public const string LCUPMT = "LCUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F52G20";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("LCDOCO", "LCDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("LCDCTO", "LCDCTO", JdeDataType.String, 4, true, true),
        new JdeField("LCKCOO", "LCKCOO", JdeDataType.String, 10, true, true),
        new JdeField("LCMCU", "LCMCU", JdeDataType.String, 24, true, true),
        new JdeField("LCJBCD", "LCJBCD", JdeDataType.String, 12, true, true),
        new JdeField("LCDESC", "LCDESC", JdeDataType.String, 60),
        new JdeField("LCLBRTY", "LCLBRTY", JdeDataType.String, 8),
        new JdeField("LCCTF1", "LCCTF1", JdeDataType.String, 2),
        new JdeField("LCFEEC", "LCFEEC", JdeDataType.String, 2),
        new JdeField("LCLOEHRS", "LCLOEHRS", JdeDataType.Numeric),
        new JdeField("LCFRTYP", "LCFRTYP", JdeDataType.String, 2),
        new JdeField("LCFEERT", "LCFEERT", JdeDataType.Numeric),
        new JdeField("LCPID", "LCPID", JdeDataType.String, 20),
        new JdeField("LCJOBN", "LCJOBN", JdeDataType.String, 20),
        new JdeField("LCUSER", "LCUSER", JdeDataType.String, 20),
        new JdeField("LCUPMJ", "LCUPMJ", JdeDataType.Numeric),
        new JdeField("LCUPMT", "LCUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F52G20_0", "Primary Key on LCDOCO, LCDCTO, LCKCOO, LCMCU, LCJBCD", new[] { "LCDOCO", "LCDCTO", "LCKCOO", "LCMCU", "LCJBCD" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F52G20_2", "Index on LCDOCO, LCDCTO, LCKCOO, LCJBCD", new[] { "LCDOCO", "LCDCTO", "LCKCOO", "LCJBCD" }),
        new JdeIndex("F52G20_3", "Index on LCMCU, LCJBCD", new[] { "LCMCU", "LCJBCD" })
    };
}
