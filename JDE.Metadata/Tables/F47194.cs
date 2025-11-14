using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F47194 - .
/// </summary>
public class F47194 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// AREDTY.
        /// </summary>
        public const string AREDTY = "AREDTY";

        /// <summary>
        /// AREDSQ.
        /// </summary>
        public const string AREDSQ = "AREDSQ";

        /// <summary>
        /// AREKCO.
        /// </summary>
        public const string AREKCO = "AREKCO";

        /// <summary>
        /// AREDOC.
        /// </summary>
        public const string AREDOC = "AREDOC";

        /// <summary>
        /// AREDCT.
        /// </summary>
        public const string AREDCT = "AREDCT";

        /// <summary>
        /// AREDLN.
        /// </summary>
        public const string AREDLN = "AREDLN";

        /// <summary>
        /// AREDST.
        /// </summary>
        public const string AREDST = "AREDST";

        /// <summary>
        /// AREDFT.
        /// </summary>
        public const string AREDFT = "AREDFT";

        /// <summary>
        /// AREDDT.
        /// </summary>
        public const string AREDDT = "AREDDT";

        /// <summary>
        /// AREDER.
        /// </summary>
        public const string AREDER = "AREDER";

        /// <summary>
        /// AREDDL.
        /// </summary>
        public const string AREDDL = "AREDDL";

        /// <summary>
        /// AREDSP.
        /// </summary>
        public const string AREDSP = "AREDSP";

        /// <summary>
        /// AREDBT.
        /// </summary>
        public const string AREDBT = "AREDBT";

        /// <summary>
        /// ARREFQLF3.
        /// </summary>
        public const string ARREFQLF3 = "ARREFQLF3";

        /// <summary>
        /// ARREFN.
        /// </summary>
        public const string ARREFN = "ARREFN";

        /// <summary>
        /// ARUSER.
        /// </summary>
        public const string ARUSER = "ARUSER";

        /// <summary>
        /// ARPID.
        /// </summary>
        public const string ARPID = "ARPID";

        /// <summary>
        /// ARJOBN.
        /// </summary>
        public const string ARJOBN = "ARJOBN";

        /// <summary>
        /// ARUPMJ.
        /// </summary>
        public const string ARUPMJ = "ARUPMJ";

        /// <summary>
        /// ARTDAY.
        /// </summary>
        public const string ARTDAY = "ARTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F47194";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("AREDTY", "AREDTY", JdeDataType.String, 2),
        new JdeField("AREDSQ", "AREDSQ", JdeDataType.Numeric),
        new JdeField("AREKCO", "AREKCO", JdeDataType.String, 10, true, true),
        new JdeField("AREDOC", "AREDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("AREDCT", "AREDCT", JdeDataType.String, 4, true, true),
        new JdeField("AREDLN", "AREDLN", JdeDataType.Numeric, null, true, true),
        new JdeField("AREDST", "AREDST", JdeDataType.String, 12),
        new JdeField("AREDFT", "AREDFT", JdeDataType.String, 20),
        new JdeField("AREDDT", "AREDDT", JdeDataType.Numeric),
        new JdeField("AREDER", "AREDER", JdeDataType.String, 2),
        new JdeField("AREDDL", "AREDDL", JdeDataType.Numeric),
        new JdeField("AREDSP", "AREDSP", JdeDataType.String, 2),
        new JdeField("AREDBT", "AREDBT", JdeDataType.String, 30),
        new JdeField("ARREFQLF3", "ARREFQLF3", JdeDataType.String, 6, true, true),
        new JdeField("ARREFN", "ARREFN", JdeDataType.String, 60),
        new JdeField("ARUSER", "ARUSER", JdeDataType.String, 20),
        new JdeField("ARPID", "ARPID", JdeDataType.String, 20),
        new JdeField("ARJOBN", "ARJOBN", JdeDataType.String, 20),
        new JdeField("ARUPMJ", "ARUPMJ", JdeDataType.Numeric),
        new JdeField("ARTDAY", "ARTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F47194_0", "Primary Key on AREKCO, AREDOC, AREDCT, AREDLN, ARREFQLF3", new[] { "AREKCO", "AREDOC", "AREDCT", "AREDLN", "ARREFQLF3" }, isUnique: true, isPrimaryKey: true)
    };
}
