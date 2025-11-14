using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F0607 - .
/// </summary>
public class F0607 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// JIAN8.
        /// </summary>
        public const string JIAN8 = "JIAN8";

        /// <summary>
        /// JIWANO.
        /// </summary>
        public const string JIWANO = "JIWANO";

        /// <summary>
        /// JIPPED.
        /// </summary>
        public const string JIPPED = "JIPPED";

        /// <summary>
        /// JINPY1.
        /// </summary>
        public const string JINPY1 = "JINPY1";

        /// <summary>
        /// JIDOCM.
        /// </summary>
        public const string JIDOCM = "JIDOCM";

        /// <summary>
        /// JICKDT.
        /// </summary>
        public const string JICKDT = "JICKDT";

        /// <summary>
        /// JIDOC.
        /// </summary>
        public const string JIDOC = "JIDOC";

        /// <summary>
        /// JIDD.
        /// </summary>
        public const string JIDD = "JIDD";

        /// <summary>
        /// JIPTCP.
        /// </summary>
        public const string JIPTCP = "JIPTCP";

        /// <summary>
        /// JIRTAM.
        /// </summary>
        public const string JIRTAM = "JIRTAM";

        /// <summary>
        /// JIWAP1.
        /// </summary>
        public const string JIWAP1 = "JIWAP1";

        /// <summary>
        /// JIWAAA.
        /// </summary>
        public const string JIWAAA = "JIWAAA";

        /// <summary>
        /// JICKCN.
        /// </summary>
        public const string JICKCN = "JICKCN";

        /// <summary>
        /// JIPDBA.
        /// </summary>
        public const string JIPDBA = "JIPDBA";

        /// <summary>
        /// JIWADW.
        /// </summary>
        public const string JIWADW = "JIWADW";

        /// <summary>
        /// JIWDA1.
        /// </summary>
        public const string JIWDA1 = "JIWDA1";

        /// <summary>
        /// JIWDA2.
        /// </summary>
        public const string JIWDA2 = "JIWDA2";

        /// <summary>
        /// JIWDA3.
        /// </summary>
        public const string JIWDA3 = "JIWDA3";

        /// <summary>
        /// JIWDA4.
        /// </summary>
        public const string JIWDA4 = "JIWDA4";

        /// <summary>
        /// JIWDA5.
        /// </summary>
        public const string JIWDA5 = "JIWDA5";

        /// <summary>
        /// JIAD.
        /// </summary>
        public const string JIAD = "JIAD";

        /// <summary>
        /// JIGPA.
        /// </summary>
        public const string JIGPA = "JIGPA";

        /// <summary>
        /// JIWAF1.
        /// </summary>
        public const string JIWAF1 = "JIWAF1";

        /// <summary>
        /// JIWAF2.
        /// </summary>
        public const string JIWAF2 = "JIWAF2";

        /// <summary>
        /// JITARA.
        /// </summary>
        public const string JITARA = "JITARA";

        /// <summary>
        /// JIWAF3.
        /// </summary>
        public const string JIWAF3 = "JIWAF3";
    }

    /// <inheritdoc />
    public override string TableName => "F0607";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("JIAN8", "JIAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("JIWANO", "JIWANO", JdeDataType.Numeric, null, true, true),
        new JdeField("JIPPED", "JIPPED", JdeDataType.Numeric, null, true, true),
        new JdeField("JINPY1", "JINPY1", JdeDataType.Numeric),
        new JdeField("JIDOCM", "JIDOCM", JdeDataType.Numeric),
        new JdeField("JICKDT", "JICKDT", JdeDataType.Numeric),
        new JdeField("JIDOC", "JIDOC", JdeDataType.Numeric),
        new JdeField("JIDD", "JIDD", JdeDataType.Numeric),
        new JdeField("JIPTCP", "JIPTCP", JdeDataType.String, 4),
        new JdeField("JIRTAM", "JIRTAM", JdeDataType.Numeric),
        new JdeField("JIWAP1", "JIWAP1", JdeDataType.Numeric),
        new JdeField("JIWAAA", "JIWAAA", JdeDataType.Numeric),
        new JdeField("JICKCN", "JICKCN", JdeDataType.Numeric),
        new JdeField("JIPDBA", "JIPDBA", JdeDataType.Numeric, null, true, true),
        new JdeField("JIWADW", "JIWADW", JdeDataType.Numeric),
        new JdeField("JIWDA1", "JIWDA1", JdeDataType.Numeric),
        new JdeField("JIWDA2", "JIWDA2", JdeDataType.Numeric),
        new JdeField("JIWDA3", "JIWDA3", JdeDataType.Numeric),
        new JdeField("JIWDA4", "JIWDA4", JdeDataType.Numeric),
        new JdeField("JIWDA5", "JIWDA5", JdeDataType.Numeric),
        new JdeField("JIAD", "JIAD", JdeDataType.Numeric),
        new JdeField("JIGPA", "JIGPA", JdeDataType.Numeric),
        new JdeField("JIWAF1", "JIWAF1", JdeDataType.Numeric),
        new JdeField("JIWAF2", "JIWAF2", JdeDataType.Numeric),
        new JdeField("JITARA", "JITARA", JdeDataType.String, 20),
        new JdeField("JIWAF3", "JIWAF3", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F0607_0", "Primary Key on JIAN8, JIWANO, JIPPED, JIPDBA", new[] { "JIAN8", "JIWANO", "JIPPED", "JIPDBA" }, isUnique: true, isPrimaryKey: true)
    };
}
