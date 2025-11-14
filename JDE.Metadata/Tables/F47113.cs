using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F47113 - .
/// </summary>
public class F47113 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// Z3EDTY.
        /// </summary>
        public const string Z3EDTY = "Z3EDTY";

        /// <summary>
        /// Z3EDSQ.
        /// </summary>
        public const string Z3EDSQ = "Z3EDSQ";

        /// <summary>
        /// Z3EKCO.
        /// </summary>
        public const string Z3EKCO = "Z3EKCO";

        /// <summary>
        /// Z3EDOC.
        /// </summary>
        public const string Z3EDOC = "Z3EDOC";

        /// <summary>
        /// Z3EDCT.
        /// </summary>
        public const string Z3EDCT = "Z3EDCT";

        /// <summary>
        /// Z3EDLN.
        /// </summary>
        public const string Z3EDLN = "Z3EDLN";

        /// <summary>
        /// Z3EDSP.
        /// </summary>
        public const string Z3EDSP = "Z3EDSP";

        /// <summary>
        /// Z3EDBT.
        /// </summary>
        public const string Z3EDBT = "Z3EDBT";

        /// <summary>
        /// Z3DEPN.
        /// </summary>
        public const string Z3DEPN = "Z3DEPN";

        /// <summary>
        /// Z3LNID.
        /// </summary>
        public const string Z3LNID = "Z3LNID";

        /// <summary>
        /// Z3DOCM.
        /// </summary>
        public const string Z3DOCM = "Z3DOCM";

        /// <summary>
        /// Z3DCTM.
        /// </summary>
        public const string Z3DCTM = "Z3DCTM";

        /// <summary>
        /// Z3DMTJ.
        /// </summary>
        public const string Z3DMTJ = "Z3DMTJ";

        /// <summary>
        /// Z3DKC.
        /// </summary>
        public const string Z3DKC = "Z3DKC";

        /// <summary>
        /// Z3AN8.
        /// </summary>
        public const string Z3AN8 = "Z3AN8";

        /// <summary>
        /// Z3ALPH.
        /// </summary>
        public const string Z3ALPH = "Z3ALPH";

        /// <summary>
        /// Z3TNST.
        /// </summary>
        public const string Z3TNST = "Z3TNST";

        /// <summary>
        /// Z3CBNK.
        /// </summary>
        public const string Z3CBNK = "Z3CBNK";

        /// <summary>
        /// Z3THCD.
        /// </summary>
        public const string Z3THCD = "Z3THCD";

        /// <summary>
        /// Z3PYCD.
        /// </summary>
        public const string Z3PYCD = "Z3PYCD";

        /// <summary>
        /// Z3PYIN.
        /// </summary>
        public const string Z3PYIN = "Z3PYIN";

        /// <summary>
        /// Z3AM.
        /// </summary>
        public const string Z3AM = "Z3AM";

        /// <summary>
        /// Z3CRCD.
        /// </summary>
        public const string Z3CRCD = "Z3CRCD";

        /// <summary>
        /// Z3CRR.
        /// </summary>
        public const string Z3CRR = "Z3CRR";

        /// <summary>
        /// Z3CRRM.
        /// </summary>
        public const string Z3CRRM = "Z3CRRM";

        /// <summary>
        /// Z3TTOT.
        /// </summary>
        public const string Z3TTOT = "Z3TTOT";

        /// <summary>
        /// Z3ICU.
        /// </summary>
        public const string Z3ICU = "Z3ICU";

        /// <summary>
        /// Z3ICUT.
        /// </summary>
        public const string Z3ICUT = "Z3ICUT";

        /// <summary>
        /// Z3DICJ.
        /// </summary>
        public const string Z3DICJ = "Z3DICJ";

        /// <summary>
        /// Z3URCD.
        /// </summary>
        public const string Z3URCD = "Z3URCD";

        /// <summary>
        /// Z3URDT.
        /// </summary>
        public const string Z3URDT = "Z3URDT";

        /// <summary>
        /// Z3URAT.
        /// </summary>
        public const string Z3URAT = "Z3URAT";

        /// <summary>
        /// Z3URAB.
        /// </summary>
        public const string Z3URAB = "Z3URAB";

        /// <summary>
        /// Z3URRF.
        /// </summary>
        public const string Z3URRF = "Z3URRF";

        /// <summary>
        /// Z3TORG.
        /// </summary>
        public const string Z3TORG = "Z3TORG";

        /// <summary>
        /// Z3USER.
        /// </summary>
        public const string Z3USER = "Z3USER";

        /// <summary>
        /// Z3PID.
        /// </summary>
        public const string Z3PID = "Z3PID";

        /// <summary>
        /// Z3JOBN.
        /// </summary>
        public const string Z3JOBN = "Z3JOBN";

        /// <summary>
        /// Z3UPMJ.
        /// </summary>
        public const string Z3UPMJ = "Z3UPMJ";

        /// <summary>
        /// Z3TDAY.
        /// </summary>
        public const string Z3TDAY = "Z3TDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F47113";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("Z3EDTY", "Z3EDTY", JdeDataType.String, 2),
        new JdeField("Z3EDSQ", "Z3EDSQ", JdeDataType.Numeric),
        new JdeField("Z3EKCO", "Z3EKCO", JdeDataType.String, 10, true, true),
        new JdeField("Z3EDOC", "Z3EDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("Z3EDCT", "Z3EDCT", JdeDataType.String, 4, true, true),
        new JdeField("Z3EDLN", "Z3EDLN", JdeDataType.Numeric, null, true, true),
        new JdeField("Z3EDSP", "Z3EDSP", JdeDataType.String, 2),
        new JdeField("Z3EDBT", "Z3EDBT", JdeDataType.String, 30),
        new JdeField("Z3DEPN", "Z3DEPN", JdeDataType.String, 60, true, true),
        new JdeField("Z3LNID", "Z3LNID", JdeDataType.Numeric, null, true, true),
        new JdeField("Z3DOCM", "Z3DOCM", JdeDataType.Numeric),
        new JdeField("Z3DCTM", "Z3DCTM", JdeDataType.String, 4),
        new JdeField("Z3DMTJ", "Z3DMTJ", JdeDataType.Numeric),
        new JdeField("Z3DKC", "Z3DKC", JdeDataType.Numeric),
        new JdeField("Z3AN8", "Z3AN8", JdeDataType.Numeric),
        new JdeField("Z3ALPH", "Z3ALPH", JdeDataType.String, 80),
        new JdeField("Z3TNST", "Z3TNST", JdeDataType.String, 40),
        new JdeField("Z3CBNK", "Z3CBNK", JdeDataType.String, 40),
        new JdeField("Z3THCD", "Z3THCD", JdeDataType.String, 2),
        new JdeField("Z3PYCD", "Z3PYCD", JdeDataType.String, 6),
        new JdeField("Z3PYIN", "Z3PYIN", JdeDataType.String, 2),
        new JdeField("Z3AM", "Z3AM", JdeDataType.String, 2),
        new JdeField("Z3CRCD", "Z3CRCD", JdeDataType.String, 6),
        new JdeField("Z3CRR", "Z3CRR", JdeDataType.Numeric),
        new JdeField("Z3CRRM", "Z3CRRM", JdeDataType.String, 2),
        new JdeField("Z3TTOT", "Z3TTOT", JdeDataType.Numeric),
        new JdeField("Z3ICU", "Z3ICU", JdeDataType.Numeric),
        new JdeField("Z3ICUT", "Z3ICUT", JdeDataType.String, 4),
        new JdeField("Z3DICJ", "Z3DICJ", JdeDataType.Numeric),
        new JdeField("Z3URCD", "Z3URCD", JdeDataType.String, 4),
        new JdeField("Z3URDT", "Z3URDT", JdeDataType.Numeric),
        new JdeField("Z3URAT", "Z3URAT", JdeDataType.Numeric),
        new JdeField("Z3URAB", "Z3URAB", JdeDataType.Numeric),
        new JdeField("Z3URRF", "Z3URRF", JdeDataType.String, 30),
        new JdeField("Z3TORG", "Z3TORG", JdeDataType.String, 20),
        new JdeField("Z3USER", "Z3USER", JdeDataType.String, 20),
        new JdeField("Z3PID", "Z3PID", JdeDataType.String, 20),
        new JdeField("Z3JOBN", "Z3JOBN", JdeDataType.String, 20),
        new JdeField("Z3UPMJ", "Z3UPMJ", JdeDataType.Numeric),
        new JdeField("Z3TDAY", "Z3TDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F47113_0", "Primary Key on Z3EDOC, Z3EDCT, Z3EKCO, Z3EDLN, Z3DEPN, Z3LNID", new[] { "Z3EDOC", "Z3EDCT", "Z3EKCO", "Z3EDLN", "Z3DEPN", "Z3LNID" }, isUnique: true, isPrimaryKey: true)
    };
}
