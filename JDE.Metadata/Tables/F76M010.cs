using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76M010 - .
/// </summary>
public class F76M010 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// LRCO.
        /// </summary>
        public const string LRCO = "LRCO";

        /// <summary>
        /// LRM76LREP.
        /// </summary>
        public const string LRM76LREP = "LRM76LREP";

        /// <summary>
        /// LRM76FNUM.
        /// </summary>
        public const string LRM76FNUM = "LRM76FNUM";

        /// <summary>
        /// LRM76FSTR.
        /// </summary>
        public const string LRM76FSTR = "LRM76FSTR";

        /// <summary>
        /// LRM76FFLG.
        /// </summary>
        public const string LRM76FFLG = "LRM76FFLG";

        /// <summary>
        /// LRM76FDAT.
        /// </summary>
        public const string LRM76FDAT = "LRM76FDAT";

        /// <summary>
        /// LRUSER.
        /// </summary>
        public const string LRUSER = "LRUSER";

        /// <summary>
        /// LRPID.
        /// </summary>
        public const string LRPID = "LRPID";

        /// <summary>
        /// LRJOBN.
        /// </summary>
        public const string LRJOBN = "LRJOBN";

        /// <summary>
        /// LRUPMJ.
        /// </summary>
        public const string LRUPMJ = "LRUPMJ";

        /// <summary>
        /// LRUPMT.
        /// </summary>
        public const string LRUPMT = "LRUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76M010";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("LRCO", "LRCO", JdeDataType.String, 10, true, true),
        new JdeField("LRM76LREP", "LRM76LREP", JdeDataType.Numeric),
        new JdeField("LRM76FNUM", "LRM76FNUM", JdeDataType.Numeric),
        new JdeField("LRM76FSTR", "LRM76FSTR", JdeDataType.String, 60),
        new JdeField("LRM76FFLG", "LRM76FFLG", JdeDataType.String, 2),
        new JdeField("LRM76FDAT", "LRM76FDAT", JdeDataType.Numeric),
        new JdeField("LRUSER", "LRUSER", JdeDataType.String, 20),
        new JdeField("LRPID", "LRPID", JdeDataType.String, 20),
        new JdeField("LRJOBN", "LRJOBN", JdeDataType.String, 20),
        new JdeField("LRUPMJ", "LRUPMJ", JdeDataType.Numeric),
        new JdeField("LRUPMT", "LRUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76M010_0", "Primary Key on LRCO", new[] { "LRCO" }, isUnique: true, isPrimaryKey: true)
    };
}
