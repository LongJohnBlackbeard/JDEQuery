using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F3106 - .
/// </summary>
public class F3106 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SDDOCO.
        /// </summary>
        public const string SDDOCO = "SDDOCO";

        /// <summary>
        /// SDDOC.
        /// </summary>
        public const string SDDOC = "SDDOC";

        /// <summary>
        /// SDDCT.
        /// </summary>
        public const string SDDCT = "SDDCT";

        /// <summary>
        /// SDDGJ.
        /// </summary>
        public const string SDDGJ = "SDDGJ";

        /// <summary>
        /// SDICU.
        /// </summary>
        public const string SDICU = "SDICU";

        /// <summary>
        /// SDICUT.
        /// </summary>
        public const string SDICUT = "SDICUT";

        /// <summary>
        /// SDDICJ.
        /// </summary>
        public const string SDDICJ = "SDDICJ";

        /// <summary>
        /// SDUSER.
        /// </summary>
        public const string SDUSER = "SDUSER";

        /// <summary>
        /// SDPID.
        /// </summary>
        public const string SDPID = "SDPID";

        /// <summary>
        /// SDJOBN.
        /// </summary>
        public const string SDJOBN = "SDJOBN";

        /// <summary>
        /// SDUPMJ.
        /// </summary>
        public const string SDUPMJ = "SDUPMJ";

        /// <summary>
        /// SDTDAY.
        /// </summary>
        public const string SDTDAY = "SDTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F3106";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SDDOCO", "SDDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("SDDOC", "SDDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("SDDCT", "SDDCT", JdeDataType.String, 4),
        new JdeField("SDDGJ", "SDDGJ", JdeDataType.Numeric, null, true, true),
        new JdeField("SDICU", "SDICU", JdeDataType.Numeric),
        new JdeField("SDICUT", "SDICUT", JdeDataType.String, 4, true, true),
        new JdeField("SDDICJ", "SDDICJ", JdeDataType.Numeric),
        new JdeField("SDUSER", "SDUSER", JdeDataType.String, 20, true, true),
        new JdeField("SDPID", "SDPID", JdeDataType.String, 20),
        new JdeField("SDJOBN", "SDJOBN", JdeDataType.String, 20),
        new JdeField("SDUPMJ", "SDUPMJ", JdeDataType.Numeric),
        new JdeField("SDTDAY", "SDTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F3106_0", "Primary Key on SDICUT, SDUSER, SDDOCO, SDDOC, SDDGJ", new[] { "SDICUT", "SDUSER", "SDDOCO", "SDDOC", "SDDGJ" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F3106_2", "Index on SDICUT, SDUSER, SDICU, SDDICJ", new[] { "SDICUT", "SDUSER", "SDICU", "SDDICJ" }),
        new JdeIndex("F3106_3", "Index on SDDOCO, SDDGJ", new[] { "SDDOCO", "SDDGJ" })
    };
}
