using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F08380WF - .
/// </summary>
public class F08380WF : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// BEJOBS.
        /// </summary>
        public const string BEJOBS = "BEJOBS";

        /// <summary>
        /// BEAN8.
        /// </summary>
        public const string BEAN8 = "BEAN8";

        /// <summary>
        /// BEALPH.
        /// </summary>
        public const string BEALPH = "BEALPH";

        /// <summary>
        /// BEBENS.
        /// </summary>
        public const string BEBENS = "BEBENS";

        /// <summary>
        /// BEPLAN.
        /// </summary>
        public const string BEPLAN = "BEPLAN";

        /// <summary>
        /// BEEXA.
        /// </summary>
        public const string BEEXA = "BEEXA";

        /// <summary>
        /// BEEFT.
        /// </summary>
        public const string BEEFT = "BEEFT";

        /// <summary>
        /// BEEFTE.
        /// </summary>
        public const string BEEFTE = "BEEFTE";

        /// <summary>
        /// BEXDFS.
        /// </summary>
        public const string BEXDFS = "BEXDFS";

        /// <summary>
        /// BEDL01.
        /// </summary>
        public const string BEDL01 = "BEDL01";

        /// <summary>
        /// BEDIVC.
        /// </summary>
        public const string BEDIVC = "BEDIVC";

        /// <summary>
        /// BESBGR.
        /// </summary>
        public const string BESBGR = "BESBGR";

        /// <summary>
        /// BEDL02.
        /// </summary>
        public const string BEDL02 = "BEDL02";

        /// <summary>
        /// BEPLNF.
        /// </summary>
        public const string BEPLNF = "BEPLNF";

        /// <summary>
        /// BEENRP.
        /// </summary>
        public const string BEENRP = "BEENRP";

        /// <summary>
        /// BEECHK.
        /// </summary>
        public const string BEECHK = "BEECHK";

        /// <summary>
        /// BEXET.
        /// </summary>
        public const string BEXET = "BEXET";

        /// <summary>
        /// BEMCHK.
        /// </summary>
        public const string BEMCHK = "BEMCHK";

        /// <summary>
        /// BEEERR.
        /// </summary>
        public const string BEEERR = "BEEERR";

        /// <summary>
        /// BEPIEN.
        /// </summary>
        public const string BEPIEN = "BEPIEN";

        /// <summary>
        /// BEPMRR.
        /// </summary>
        public const string BEPMRR = "BEPMRR";

        /// <summary>
        /// BEPACT.
        /// </summary>
        public const string BEPACT = "BEPACT";

        /// <summary>
        /// BEPOEL.
        /// </summary>
        public const string BEPOEL = "BEPOEL";
    }

    /// <inheritdoc />
    public override string TableName => "F08380WF";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("BEJOBS", "BEJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("BEAN8", "BEAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("BEALPH", "BEALPH", JdeDataType.String, 80),
        new JdeField("BEBENS", "BEBENS", JdeDataType.String, 2),
        new JdeField("BEPLAN", "BEPLAN", JdeDataType.String, 16, true, true),
        new JdeField("BEEXA", "BEEXA", JdeDataType.String, 60),
        new JdeField("BEEFT", "BEEFT", JdeDataType.Numeric, null, true, true),
        new JdeField("BEEFTE", "BEEFTE", JdeDataType.Numeric),
        new JdeField("BEXDFS", "BEXDFS", JdeDataType.String, 6),
        new JdeField("BEDL01", "BEDL01", JdeDataType.String, 60),
        new JdeField("BEDIVC", "BEDIVC", JdeDataType.String, 12),
        new JdeField("BESBGR", "BESBGR", JdeDataType.String, 20, true, true),
        new JdeField("BEDL02", "BEDL02", JdeDataType.String, 60),
        new JdeField("BEPLNF", "BEPLNF", JdeDataType.String, 2),
        new JdeField("BEENRP", "BEENRP", JdeDataType.String, 2),
        new JdeField("BEECHK", "BEECHK", JdeDataType.String, 2),
        new JdeField("BEXET", "BEXET", JdeDataType.String, 8),
        new JdeField("BEMCHK", "BEMCHK", JdeDataType.String, 2),
        new JdeField("BEEERR", "BEEERR", JdeDataType.String, 2),
        new JdeField("BEPIEN", "BEPIEN", JdeDataType.String, 2),
        new JdeField("BEPMRR", "BEPMRR", JdeDataType.String, 2),
        new JdeField("BEPACT", "BEPACT", JdeDataType.String, 2),
        new JdeField("BEPOEL", "BEPOEL", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F08380WF_0", "Primary Key on BEPLAN, BEEFT, BESBGR, BEAN8, BEJOBS", new[] { "BEPLAN", "BEEFT", "BESBGR", "BEAN8", "BEJOBS" }, isUnique: true, isPrimaryKey: true)
    };
}
