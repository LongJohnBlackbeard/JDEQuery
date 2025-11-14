using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F81A122 - .
/// </summary>
public class F81A122 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// M4LDFR.
        /// </summary>
        public const string M4LDFR = "M4LDFR";

        /// <summary>
        /// M4PID.
        /// </summary>
        public const string M4PID = "M4PID";

        /// <summary>
        /// M4VERS.
        /// </summary>
        public const string M4VERS = "M4VERS";

        /// <summary>
        /// M4OPT#.
        /// </summary>
        public const string M4OPT_ = "M4OPT#";

        /// <summary>
        /// M4SVL.
        /// </summary>
        public const string M4SVL = "M4SVL";

        /// <summary>
        /// M4FPID.
        /// </summary>
        public const string M4FPID = "M4FPID";

        /// <summary>
        /// M4BVER.
        /// </summary>
        public const string M4BVER = "M4BVER";

        /// <summary>
        /// M4OBNM.
        /// </summary>
        public const string M4OBNM = "M4OBNM";

        /// <summary>
        /// M4LITN.
        /// </summary>
        public const string M4LITN = "M4LITN";

        /// <summary>
        /// M4BSQN.
        /// </summary>
        public const string M4BSQN = "M4BSQN";

        /// <summary>
        /// M4BCNT.
        /// </summary>
        public const string M4BCNT = "M4BCNT";

        /// <summary>
        /// M4LNGP.
        /// </summary>
        public const string M4LNGP = "M4LNGP";

        /// <summary>
        /// M4OWTP.
        /// </summary>
        public const string M4OWTP = "M4OWTP";

        /// <summary>
        /// M4DTAI.
        /// </summary>
        public const string M4DTAI = "M4DTAI";

        /// <summary>
        /// M4VL01.
        /// </summary>
        public const string M4VL01 = "M4VL01";

        /// <summary>
        /// M4BNUM.
        /// </summary>
        public const string M4BNUM = "M4BNUM";

        /// <summary>
        /// M4LUS.
        /// </summary>
        public const string M4LUS = "M4LUS";

        /// <summary>
        /// M4FPD.
        /// </summary>
        public const string M4FPD = "M4FPD";

        /// <summary>
        /// M4UPMJ.
        /// </summary>
        public const string M4UPMJ = "M4UPMJ";

        /// <summary>
        /// M4JOBN.
        /// </summary>
        public const string M4JOBN = "M4JOBN";

        /// <summary>
        /// M4UPMT.
        /// </summary>
        public const string M4UPMT = "M4UPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F81A122";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("M4LDFR", "M4LDFR", JdeDataType.String, 20, true, true),
        new JdeField("M4PID", "M4PID", JdeDataType.String, 20, true, true),
        new JdeField("M4VERS", "M4VERS", JdeDataType.String, 20, true, true),
        new JdeField("M4OPT#", "M4OPT#", JdeDataType.Numeric, null, true, true),
        new JdeField("M4SVL", "M4SVL", JdeDataType.String, 50),
        new JdeField("M4FPID", "M4FPID", JdeDataType.String, 20, true, true),
        new JdeField("M4BVER", "M4BVER", JdeDataType.String, 20, true, true),
        new JdeField("M4OBNM", "M4OBNM", JdeDataType.String, 20),
        new JdeField("M4LITN", "M4LITN", JdeDataType.Numeric),
        new JdeField("M4BSQN", "M4BSQN", JdeDataType.Numeric),
        new JdeField("M4BCNT", "M4BCNT", JdeDataType.Numeric, null, true, true),
        new JdeField("M4LNGP", "M4LNGP", JdeDataType.String, 4),
        new JdeField("M4OWTP", "M4OWTP", JdeDataType.String, 4),
        new JdeField("M4DTAI", "M4DTAI", JdeDataType.String, 20),
        new JdeField("M4VL01", "M4VL01", JdeDataType.String, 50),
        new JdeField("M4BNUM", "M4BNUM", JdeDataType.Numeric),
        new JdeField("M4LUS", "M4LUS", JdeDataType.String, 20),
        new JdeField("M4FPD", "M4FPD", JdeDataType.String, 20),
        new JdeField("M4UPMJ", "M4UPMJ", JdeDataType.Numeric),
        new JdeField("M4JOBN", "M4JOBN", JdeDataType.String, 20),
        new JdeField("M4UPMT", "M4UPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F81A122_0", "Primary Key on M4LDFR, M4PID, M4VERS, M4OPT#, M4FPID, M4BVER, M4BCNT", new[] { "M4LDFR", "M4PID", "M4VERS", "M4OPT#", "M4FPID", "M4BVER", "M4BCNT" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F81A122_2", "Index on M4FPID, M4BVER, M4BCNT", new[] { "M4FPID", "M4BVER", "M4BCNT" }),
        new JdeIndex("F81A122_3", "Index on M4FPID, M4BVER, M4LITN, M4BSQN", new[] { "M4FPID", "M4BVER", "M4LITN", "M4BSQN" })
    };
}
