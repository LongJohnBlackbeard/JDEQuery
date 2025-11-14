using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F47198 - .
/// </summary>
public class F47198 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ANEDTY.
        /// </summary>
        public const string ANEDTY = "ANEDTY";

        /// <summary>
        /// ANEDSQ.
        /// </summary>
        public const string ANEDSQ = "ANEDSQ";

        /// <summary>
        /// ANEKCO.
        /// </summary>
        public const string ANEKCO = "ANEKCO";

        /// <summary>
        /// ANEDOC.
        /// </summary>
        public const string ANEDOC = "ANEDOC";

        /// <summary>
        /// ANEDCT.
        /// </summary>
        public const string ANEDCT = "ANEDCT";

        /// <summary>
        /// ANEDLN.
        /// </summary>
        public const string ANEDLN = "ANEDLN";

        /// <summary>
        /// ANEDST.
        /// </summary>
        public const string ANEDST = "ANEDST";

        /// <summary>
        /// ANEDFT.
        /// </summary>
        public const string ANEDFT = "ANEDFT";

        /// <summary>
        /// ANEDDT.
        /// </summary>
        public const string ANEDDT = "ANEDDT";

        /// <summary>
        /// ANEDER.
        /// </summary>
        public const string ANEDER = "ANEDER";

        /// <summary>
        /// ANEDDL.
        /// </summary>
        public const string ANEDDL = "ANEDDL";

        /// <summary>
        /// ANEDSP.
        /// </summary>
        public const string ANEDSP = "ANEDSP";

        /// <summary>
        /// ANEDBT.
        /// </summary>
        public const string ANEDBT = "ANEDBT";

        /// <summary>
        /// ANFTXTQLF.
        /// </summary>
        public const string ANFTXTQLF = "ANFTXTQLF";

        /// <summary>
        /// ANFREETEXT.
        /// </summary>
        public const string ANFREETEXT = "ANFREETEXT";

        /// <summary>
        /// ANUSER.
        /// </summary>
        public const string ANUSER = "ANUSER";

        /// <summary>
        /// ANPID.
        /// </summary>
        public const string ANPID = "ANPID";

        /// <summary>
        /// ANJOBN.
        /// </summary>
        public const string ANJOBN = "ANJOBN";

        /// <summary>
        /// ANUPMJ.
        /// </summary>
        public const string ANUPMJ = "ANUPMJ";

        /// <summary>
        /// ANTDAY.
        /// </summary>
        public const string ANTDAY = "ANTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F47198";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ANEDTY", "ANEDTY", JdeDataType.String, 2),
        new JdeField("ANEDSQ", "ANEDSQ", JdeDataType.Numeric),
        new JdeField("ANEKCO", "ANEKCO", JdeDataType.String, 10, true, true),
        new JdeField("ANEDOC", "ANEDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("ANEDCT", "ANEDCT", JdeDataType.String, 4, true, true),
        new JdeField("ANEDLN", "ANEDLN", JdeDataType.Numeric, null, true, true),
        new JdeField("ANEDST", "ANEDST", JdeDataType.String, 12),
        new JdeField("ANEDFT", "ANEDFT", JdeDataType.String, 20),
        new JdeField("ANEDDT", "ANEDDT", JdeDataType.Numeric),
        new JdeField("ANEDER", "ANEDER", JdeDataType.String, 2),
        new JdeField("ANEDDL", "ANEDDL", JdeDataType.Numeric),
        new JdeField("ANEDSP", "ANEDSP", JdeDataType.String, 2),
        new JdeField("ANEDBT", "ANEDBT", JdeDataType.String, 30),
        new JdeField("ANFTXTQLF", "ANFTXTQLF", JdeDataType.String, 6, true, true),
        new JdeField("ANFREETEXT", "ANFREETEXT", JdeDataType.String, 140),
        new JdeField("ANUSER", "ANUSER", JdeDataType.String, 20),
        new JdeField("ANPID", "ANPID", JdeDataType.String, 20),
        new JdeField("ANJOBN", "ANJOBN", JdeDataType.String, 20),
        new JdeField("ANUPMJ", "ANUPMJ", JdeDataType.Numeric),
        new JdeField("ANTDAY", "ANTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F47198_0", "Primary Key on ANEKCO, ANEDOC, ANEDCT, ANEDLN, ANFTXTQLF", new[] { "ANEKCO", "ANEDOC", "ANEDCT", "ANEDLN", "ANFTXTQLF" }, isUnique: true, isPrimaryKey: true)
    };
}
