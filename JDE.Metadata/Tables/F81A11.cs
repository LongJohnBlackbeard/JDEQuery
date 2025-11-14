using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F81A11 - .
/// </summary>
public class F81A11 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// M3LDFR.
        /// </summary>
        public const string M3LDFR = "M3LDFR";

        /// <summary>
        /// M3PID.
        /// </summary>
        public const string M3PID = "M3PID";

        /// <summary>
        /// M3VERS.
        /// </summary>
        public const string M3VERS = "M3VERS";

        /// <summary>
        /// M3FPID.
        /// </summary>
        public const string M3FPID = "M3FPID";

        /// <summary>
        /// M3BVER.
        /// </summary>
        public const string M3BVER = "M3BVER";

        /// <summary>
        /// M3LRID.
        /// </summary>
        public const string M3LRID = "M3LRID";

        /// <summary>
        /// M3LVRI.
        /// </summary>
        public const string M3LVRI = "M3LVRI";

        /// <summary>
        /// M3JD.
        /// </summary>
        public const string M3JD = "M3JD";

        /// <summary>
        /// M3EXCL.
        /// </summary>
        public const string M3EXCL = "M3EXCL";

        /// <summary>
        /// M3USER.
        /// </summary>
        public const string M3USER = "M3USER";

        /// <summary>
        /// M3VCD.
        /// </summary>
        public const string M3VCD = "M3VCD";

        /// <summary>
        /// M3VED.
        /// </summary>
        public const string M3VED = "M3VED";

        /// <summary>
        /// M3LPRO.
        /// </summary>
        public const string M3LPRO = "M3LPRO";

        /// <summary>
        /// M3OPCR.
        /// </summary>
        public const string M3OPCR = "M3OPCR";

        /// <summary>
        /// M3LVLM.
        /// </summary>
        public const string M3LVLM = "M3LVLM";

        /// <summary>
        /// M3LVTI.
        /// </summary>
        public const string M3LVTI = "M3LVTI";

        /// <summary>
        /// M3LCKS.
        /// </summary>
        public const string M3LCKS = "M3LCKS";

        /// <summary>
        /// M3LCKD.
        /// </summary>
        public const string M3LCKD = "M3LCKD";

        /// <summary>
        /// M3LUS0.
        /// </summary>
        public const string M3LUS0 = "M3LUS0";

        /// <summary>
        /// M3LVRA.
        /// </summary>
        public const string M3LVRA = "M3LVRA";

        /// <summary>
        /// M3ENHV.
        /// </summary>
        public const string M3ENHV = "M3ENHV";

        /// <summary>
        /// M3MKEY.
        /// </summary>
        public const string M3MKEY = "M3MKEY";

        /// <summary>
        /// M3LDSN.
        /// </summary>
        public const string M3LDSN = "M3LDSN";

        /// <summary>
        /// M3LVC1.
        /// </summary>
        public const string M3LVC1 = "M3LVC1";

        /// <summary>
        /// M3LVC2.
        /// </summary>
        public const string M3LVC2 = "M3LVC2";

        /// <summary>
        /// M3LVC3.
        /// </summary>
        public const string M3LVC3 = "M3LVC3";

        /// <summary>
        /// M3LVC4.
        /// </summary>
        public const string M3LVC4 = "M3LVC4";

        /// <summary>
        /// M3LVC5.
        /// </summary>
        public const string M3LVC5 = "M3LVC5";

        /// <summary>
        /// M3LFTS.
        /// </summary>
        public const string M3LFTS = "M3LFTS";

        /// <summary>
        /// M3LEST.
        /// </summary>
        public const string M3LEST = "M3LEST";

        /// <summary>
        /// M3LUST.
        /// </summary>
        public const string M3LUST = "M3LUST";

        /// <summary>
        /// M3LUS.
        /// </summary>
        public const string M3LUS = "M3LUS";

        /// <summary>
        /// M3FPD.
        /// </summary>
        public const string M3FPD = "M3FPD";

        /// <summary>
        /// M3UPMJ.
        /// </summary>
        public const string M3UPMJ = "M3UPMJ";

        /// <summary>
        /// M3JOBN.
        /// </summary>
        public const string M3JOBN = "M3JOBN";

        /// <summary>
        /// M3UPMT.
        /// </summary>
        public const string M3UPMT = "M3UPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F81A11";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("M3LDFR", "M3LDFR", JdeDataType.String, 20, true, true),
        new JdeField("M3PID", "M3PID", JdeDataType.String, 20, true, true),
        new JdeField("M3VERS", "M3VERS", JdeDataType.String, 20, true, true),
        new JdeField("M3FPID", "M3FPID", JdeDataType.String, 20, true, true),
        new JdeField("M3BVER", "M3BVER", JdeDataType.String, 20, true, true),
        new JdeField("M3LRID", "M3LRID", JdeDataType.Numeric),
        new JdeField("M3LVRI", "M3LVRI", JdeDataType.Numeric),
        new JdeField("M3JD", "M3JD", JdeDataType.String, 100),
        new JdeField("M3EXCL", "M3EXCL", JdeDataType.String, 2),
        new JdeField("M3USER", "M3USER", JdeDataType.String, 20),
        new JdeField("M3VCD", "M3VCD", JdeDataType.Numeric),
        new JdeField("M3VED", "M3VED", JdeDataType.Numeric),
        new JdeField("M3LPRO", "M3LPRO", JdeDataType.Numeric),
        new JdeField("M3OPCR", "M3OPCR", JdeDataType.String, 2),
        new JdeField("M3LVLM", "M3LVLM", JdeDataType.Numeric),
        new JdeField("M3LVTI", "M3LVTI", JdeDataType.Numeric),
        new JdeField("M3LCKS", "M3LCKS", JdeDataType.String, 2),
        new JdeField("M3LCKD", "M3LCKD", JdeDataType.String, 12),
        new JdeField("M3LUS0", "M3LUS0", JdeDataType.String, 20),
        new JdeField("M3LVRA", "M3LVRA", JdeDataType.String, 2),
        new JdeField("M3ENHV", "M3ENHV", JdeDataType.String, 20),
        new JdeField("M3MKEY", "M3MKEY", JdeDataType.String, 30),
        new JdeField("M3LDSN", "M3LDSN", JdeDataType.String, 20),
        new JdeField("M3LVC1", "M3LVC1", JdeDataType.String, 6),
        new JdeField("M3LVC2", "M3LVC2", JdeDataType.String, 6),
        new JdeField("M3LVC3", "M3LVC3", JdeDataType.String, 6),
        new JdeField("M3LVC4", "M3LVC4", JdeDataType.String, 6),
        new JdeField("M3LVC5", "M3LVC5", JdeDataType.String, 6),
        new JdeField("M3LFTS", "M3LFTS", JdeDataType.String, 508),
        new JdeField("M3LEST", "M3LEST", JdeDataType.String, 2),
        new JdeField("M3LUST", "M3LUST", JdeDataType.String, 2),
        new JdeField("M3LUS", "M3LUS", JdeDataType.String, 20),
        new JdeField("M3FPD", "M3FPD", JdeDataType.String, 20),
        new JdeField("M3UPMJ", "M3UPMJ", JdeDataType.Numeric),
        new JdeField("M3JOBN", "M3JOBN", JdeDataType.String, 20),
        new JdeField("M3UPMT", "M3UPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F81A11_0", "Primary Key on M3LDFR, M3PID, M3VERS, M3FPID, M3BVER", new[] { "M3LDFR", "M3PID", "M3VERS", "M3FPID", "M3BVER" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F81A11_2", "Index on M3FPID, M3BVER", new[] { "M3FPID", "M3BVER" })
    };
}
