using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F34A150 - .
/// </summary>
public class F34A150 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RRDOCO.
        /// </summary>
        public const string RRDOCO = "RRDOCO";

        /// <summary>
        /// RRMCU.
        /// </summary>
        public const string RRMCU = "RRMCU";

        /// <summary>
        /// RROPSQ.
        /// </summary>
        public const string RROPSQ = "RROPSQ";

        /// <summary>
        /// RROPSC.
        /// </summary>
        public const string RROPSC = "RROPSC";

        /// <summary>
        /// RRLNID.
        /// </summary>
        public const string RRLNID = "RRLNID";

        /// <summary>
        /// RRRESCD.
        /// </summary>
        public const string RRRESCD = "RRRESCD";

        /// <summary>
        /// RRAPSREST.
        /// </summary>
        public const string RRAPSREST = "RRAPSREST";

        /// <summary>
        /// RRSCHST.
        /// </summary>
        public const string RRSCHST = "RRSCHST";

        /// <summary>
        /// RRSCHET.
        /// </summary>
        public const string RRSCHET = "RRSCHET";

        /// <summary>
        /// RRRUNTM.
        /// </summary>
        public const string RRRUNTM = "RRRUNTM";

        /// <summary>
        /// RRTUOM.
        /// </summary>
        public const string RRTUOM = "RRTUOM";

        /// <summary>
        /// RRURDT.
        /// </summary>
        public const string RRURDT = "RRURDT";

        /// <summary>
        /// RRURAT.
        /// </summary>
        public const string RRURAT = "RRURAT";

        /// <summary>
        /// RRURRF.
        /// </summary>
        public const string RRURRF = "RRURRF";

        /// <summary>
        /// RRURCD.
        /// </summary>
        public const string RRURCD = "RRURCD";

        /// <summary>
        /// RRUSER.
        /// </summary>
        public const string RRUSER = "RRUSER";

        /// <summary>
        /// RRPID.
        /// </summary>
        public const string RRPID = "RRPID";

        /// <summary>
        /// RRUPMJ.
        /// </summary>
        public const string RRUPMJ = "RRUPMJ";

        /// <summary>
        /// RRDURR.
        /// </summary>
        public const string RRDURR = "RRDURR";
    }

    /// <inheritdoc />
    public override string TableName => "F34A150";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RRDOCO", "RRDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("RRMCU", "RRMCU", JdeDataType.String, 24, true, true),
        new JdeField("RROPSQ", "RROPSQ", JdeDataType.Numeric, null, true, true),
        new JdeField("RROPSC", "RROPSC", JdeDataType.String, 4, true, true),
        new JdeField("RRLNID", "RRLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("RRRESCD", "RRRESCD", JdeDataType.String, 24),
        new JdeField("RRAPSREST", "RRAPSREST", JdeDataType.String, 2),
        new JdeField("RRSCHST", "RRSCHST", JdeDataType.Date),
        new JdeField("RRSCHET", "RRSCHET", JdeDataType.Date),
        new JdeField("RRRUNTM", "RRRUNTM", JdeDataType.Numeric),
        new JdeField("RRTUOM", "RRTUOM", JdeDataType.String, 2),
        new JdeField("RRURDT", "RRURDT", JdeDataType.Numeric),
        new JdeField("RRURAT", "RRURAT", JdeDataType.Numeric),
        new JdeField("RRURRF", "RRURRF", JdeDataType.String, 30),
        new JdeField("RRURCD", "RRURCD", JdeDataType.String, 4),
        new JdeField("RRUSER", "RRUSER", JdeDataType.String, 20),
        new JdeField("RRPID", "RRPID", JdeDataType.String, 20),
        new JdeField("RRUPMJ", "RRUPMJ", JdeDataType.Numeric),
        new JdeField("RRDURR", "RRDURR", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F34A150_0", "Primary Key on RRDOCO, RRMCU, RROPSQ, RROPSC, RRLNID", new[] { "RRDOCO", "RRMCU", "RROPSQ", "RROPSC", "RRLNID" }, isUnique: true, isPrimaryKey: true)
    };
}
