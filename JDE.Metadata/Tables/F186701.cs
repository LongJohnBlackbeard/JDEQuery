using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F186701 - .
/// </summary>
public class F186701 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RRLRSRRID.
        /// </summary>
        public const string RRLRSRRID = "RRLRSRRID";

        /// <summary>
        /// RRLRSRRN.
        /// </summary>
        public const string RRLRSRRN = "RRLRSRRN";

        /// <summary>
        /// RRLRSEGID.
        /// </summary>
        public const string RRLRSEGID = "RRLRSEGID";

        /// <summary>
        /// RRLRSTEMV.
        /// </summary>
        public const string RRLRSTEMV = "RRLRSTEMV";

        /// <summary>
        /// RRLRSRSD.
        /// </summary>
        public const string RRLRSRSD = "RRLRSRSD";

        /// <summary>
        /// RRLRSRED.
        /// </summary>
        public const string RRLRSRED = "RRLRSRED";

        /// <summary>
        /// RRLRSNWDF.
        /// </summary>
        public const string RRLRSNWDF = "RRLRSNWDF";

        /// <summary>
        /// RRLRSNDWK.
        /// </summary>
        public const string RRLRSNDWK = "RRLRSNDWK";

        /// <summary>
        /// RRLRSNPTF.
        /// </summary>
        public const string RRLRSNPTF = "RRLRSNPTF";

        /// <summary>
        /// RRLRSNPT.
        /// </summary>
        public const string RRLRSNPT = "RRLRSNPT";

        /// <summary>
        /// RRLRSNHRF.
        /// </summary>
        public const string RRLRSNHRF = "RRLRSNHRF";

        /// <summary>
        /// RRLRSNHRZ.
        /// </summary>
        public const string RRLRSNHRZ = "RRLRSNHRZ";

        /// <summary>
        /// RRLRSNHWF.
        /// </summary>
        public const string RRLRSNHWF = "RRLRSNHWF";

        /// <summary>
        /// RRLRSNHWZ.
        /// </summary>
        public const string RRLRSNHWZ = "RRLRSNHWZ";

        /// <summary>
        /// RRLRSRZHF.
        /// </summary>
        public const string RRLRSRZHF = "RRLRSRZHF";

        /// <summary>
        /// RRLRSPTIF.
        /// </summary>
        public const string RRLRSPTIF = "RRLRSPTIF";

        /// <summary>
        /// RRUSER.
        /// </summary>
        public const string RRUSER = "RRUSER";

        /// <summary>
        /// RRPID.
        /// </summary>
        public const string RRPID = "RRPID";

        /// <summary>
        /// RRJOBN.
        /// </summary>
        public const string RRJOBN = "RRJOBN";

        /// <summary>
        /// RRUPMJ.
        /// </summary>
        public const string RRUPMJ = "RRUPMJ";

        /// <summary>
        /// RRTDAY.
        /// </summary>
        public const string RRTDAY = "RRTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F186701";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RRLRSRRID", "RRLRSRRID", JdeDataType.Numeric, null, true, true),
        new JdeField("RRLRSRRN", "RRLRSRRN", JdeDataType.String, 60),
        new JdeField("RRLRSEGID", "RRLRSEGID", JdeDataType.Numeric),
        new JdeField("RRLRSTEMV", "RRLRSTEMV", JdeDataType.String, 20),
        new JdeField("RRLRSRSD", "RRLRSRSD", JdeDataType.Numeric),
        new JdeField("RRLRSRED", "RRLRSRED", JdeDataType.Numeric),
        new JdeField("RRLRSNWDF", "RRLRSNWDF", JdeDataType.String, 2),
        new JdeField("RRLRSNDWK", "RRLRSNDWK", JdeDataType.Numeric),
        new JdeField("RRLRSNPTF", "RRLRSNPTF", JdeDataType.String, 2),
        new JdeField("RRLRSNPT", "RRLRSNPT", JdeDataType.Numeric),
        new JdeField("RRLRSNHRF", "RRLRSNHRF", JdeDataType.String, 2),
        new JdeField("RRLRSNHRZ", "RRLRSNHRZ", JdeDataType.String, 510),
        new JdeField("RRLRSNHWF", "RRLRSNHWF", JdeDataType.String, 2),
        new JdeField("RRLRSNHWZ", "RRLRSNHWZ", JdeDataType.String, 510),
        new JdeField("RRLRSRZHF", "RRLRSRZHF", JdeDataType.String, 2),
        new JdeField("RRLRSPTIF", "RRLRSPTIF", JdeDataType.String, 2),
        new JdeField("RRUSER", "RRUSER", JdeDataType.String, 20),
        new JdeField("RRPID", "RRPID", JdeDataType.String, 20),
        new JdeField("RRJOBN", "RRJOBN", JdeDataType.String, 20),
        new JdeField("RRUPMJ", "RRUPMJ", JdeDataType.Numeric),
        new JdeField("RRTDAY", "RRTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F186701_0", "Primary Key on RRLRSRRID", new[] { "RRLRSRRID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F186701_2", "Index on RRLRSEGID", new[] { "RRLRSEGID" }),
        new JdeIndex("F186701_3", "Unique Index on RRLRSRRN", new[] { "RRLRSRRN" }, isUnique: true)
    };
}
