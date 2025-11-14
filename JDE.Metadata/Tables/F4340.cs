using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4340 - .
/// </summary>
public class F4340 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RDAN8.
        /// </summary>
        public const string RDAN8 = "RDAN8";

        /// <summary>
        /// RDAGSQ.
        /// </summary>
        public const string RDAGSQ = "RDAGSQ";

        /// <summary>
        /// RDCO.
        /// </summary>
        public const string RDCO = "RDCO";

        /// <summary>
        /// RDDL01.
        /// </summary>
        public const string RDDL01 = "RDDL01";

        /// <summary>
        /// RDEFTJ.
        /// </summary>
        public const string RDEFTJ = "RDEFTJ";

        /// <summary>
        /// RDEXDJ.
        /// </summary>
        public const string RDEXDJ = "RDEXDJ";

        /// <summary>
        /// RDTHRT.
        /// </summary>
        public const string RDTHRT = "RDTHRT";

        /// <summary>
        /// RDUOM.
        /// </summary>
        public const string RDUOM = "RDUOM";

        /// <summary>
        /// RDCRCD.
        /// </summary>
        public const string RDCRCD = "RDCRCD";

        /// <summary>
        /// RDREBN.
        /// </summary>
        public const string RDREBN = "RDREBN";

        /// <summary>
        /// RDRBST.
        /// </summary>
        public const string RDRBST = "RDRBST";

        /// <summary>
        /// RDANSA.
        /// </summary>
        public const string RDANSA = "RDANSA";

        /// <summary>
        /// RDSTMJ.
        /// </summary>
        public const string RDSTMJ = "RDSTMJ";

        /// <summary>
        /// RDGLC.
        /// </summary>
        public const string RDGLC = "RDGLC";

        /// <summary>
        /// RDLSDJ.
        /// </summary>
        public const string RDLSDJ = "RDLSDJ";

        /// <summary>
        /// RDPVL.
        /// </summary>
        public const string RDPVL = "RDPVL";

        /// <summary>
        /// RDPQT.
        /// </summary>
        public const string RDPQT = "RDPQT";

        /// <summary>
        /// RDREBO.
        /// </summary>
        public const string RDREBO = "RDREBO";

        /// <summary>
        /// RDURCD.
        /// </summary>
        public const string RDURCD = "RDURCD";

        /// <summary>
        /// RDURDT.
        /// </summary>
        public const string RDURDT = "RDURDT";

        /// <summary>
        /// RDURAT.
        /// </summary>
        public const string RDURAT = "RDURAT";

        /// <summary>
        /// RDURAB.
        /// </summary>
        public const string RDURAB = "RDURAB";

        /// <summary>
        /// RDURRF.
        /// </summary>
        public const string RDURRF = "RDURRF";

        /// <summary>
        /// RDUSER.
        /// </summary>
        public const string RDUSER = "RDUSER";

        /// <summary>
        /// RDPID.
        /// </summary>
        public const string RDPID = "RDPID";

        /// <summary>
        /// RDJOBN.
        /// </summary>
        public const string RDJOBN = "RDJOBN";

        /// <summary>
        /// RDUPMJ.
        /// </summary>
        public const string RDUPMJ = "RDUPMJ";

        /// <summary>
        /// RDTDAY.
        /// </summary>
        public const string RDTDAY = "RDTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F4340";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RDAN8", "RDAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("RDAGSQ", "RDAGSQ", JdeDataType.Numeric, null, true, true),
        new JdeField("RDCO", "RDCO", JdeDataType.String, 10),
        new JdeField("RDDL01", "RDDL01", JdeDataType.String, 60),
        new JdeField("RDEFTJ", "RDEFTJ", JdeDataType.Numeric),
        new JdeField("RDEXDJ", "RDEXDJ", JdeDataType.Numeric),
        new JdeField("RDTHRT", "RDTHRT", JdeDataType.String, 2),
        new JdeField("RDUOM", "RDUOM", JdeDataType.String, 4),
        new JdeField("RDCRCD", "RDCRCD", JdeDataType.String, 6),
        new JdeField("RDREBN", "RDREBN", JdeDataType.String, 2),
        new JdeField("RDRBST", "RDRBST", JdeDataType.String, 2),
        new JdeField("RDANSA", "RDANSA", JdeDataType.Numeric),
        new JdeField("RDSTMJ", "RDSTMJ", JdeDataType.String, 2),
        new JdeField("RDGLC", "RDGLC", JdeDataType.String, 8),
        new JdeField("RDLSDJ", "RDLSDJ", JdeDataType.Numeric),
        new JdeField("RDPVL", "RDPVL", JdeDataType.Numeric),
        new JdeField("RDPQT", "RDPQT", JdeDataType.Numeric),
        new JdeField("RDREBO", "RDREBO", JdeDataType.Numeric),
        new JdeField("RDURCD", "RDURCD", JdeDataType.String, 4),
        new JdeField("RDURDT", "RDURDT", JdeDataType.Numeric),
        new JdeField("RDURAT", "RDURAT", JdeDataType.Numeric),
        new JdeField("RDURAB", "RDURAB", JdeDataType.Numeric),
        new JdeField("RDURRF", "RDURRF", JdeDataType.String, 30),
        new JdeField("RDUSER", "RDUSER", JdeDataType.String, 20),
        new JdeField("RDPID", "RDPID", JdeDataType.String, 20),
        new JdeField("RDJOBN", "RDJOBN", JdeDataType.String, 20),
        new JdeField("RDUPMJ", "RDUPMJ", JdeDataType.Numeric),
        new JdeField("RDTDAY", "RDTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4340_0", "Primary Key on RDAN8, RDAGSQ", new[] { "RDAN8", "RDAGSQ" }, isUnique: true, isPrimaryKey: true)
    };
}
