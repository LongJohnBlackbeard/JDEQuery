using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F0401 - .
/// </summary>
public class F0401 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// A6AN8.
        /// </summary>
        public const string A6AN8 = "A6AN8";

        /// <summary>
        /// A6APC.
        /// </summary>
        public const string A6APC = "A6APC";

        /// <summary>
        /// A6MCUP.
        /// </summary>
        public const string A6MCUP = "A6MCUP";

        /// <summary>
        /// A6OBAP.
        /// </summary>
        public const string A6OBAP = "A6OBAP";

        /// <summary>
        /// A6AIDP.
        /// </summary>
        public const string A6AIDP = "A6AIDP";

        /// <summary>
        /// A6KCOP.
        /// </summary>
        public const string A6KCOP = "A6KCOP";

        /// <summary>
        /// A6DCAP.
        /// </summary>
        public const string A6DCAP = "A6DCAP";

        /// <summary>
        /// A6DTAP.
        /// </summary>
        public const string A6DTAP = "A6DTAP";

        /// <summary>
        /// A6CRRP.
        /// </summary>
        public const string A6CRRP = "A6CRRP";

        /// <summary>
        /// A6TXA2.
        /// </summary>
        public const string A6TXA2 = "A6TXA2";

        /// <summary>
        /// A6EXR2.
        /// </summary>
        public const string A6EXR2 = "A6EXR2";

        /// <summary>
        /// A6HDPY.
        /// </summary>
        public const string A6HDPY = "A6HDPY";

        /// <summary>
        /// A6TXA3.
        /// </summary>
        public const string A6TXA3 = "A6TXA3";

        /// <summary>
        /// A6EXR3.
        /// </summary>
        public const string A6EXR3 = "A6EXR3";

        /// <summary>
        /// A6TAWH.
        /// </summary>
        public const string A6TAWH = "A6TAWH";

        /// <summary>
        /// A6PCWH.
        /// </summary>
        public const string A6PCWH = "A6PCWH";

        /// <summary>
        /// A6TRAP.
        /// </summary>
        public const string A6TRAP = "A6TRAP";

        /// <summary>
        /// A6SCK.
        /// </summary>
        public const string A6SCK = "A6SCK";

        /// <summary>
        /// A6PYIN.
        /// </summary>
        public const string A6PYIN = "A6PYIN";

        /// <summary>
        /// A6SNTO.
        /// </summary>
        public const string A6SNTO = "A6SNTO";

        /// <summary>
        /// A6AB1.
        /// </summary>
        public const string A6AB1 = "A6AB1";

        /// <summary>
        /// A6FLD.
        /// </summary>
        public const string A6FLD = "A6FLD";

        /// <summary>
        /// A6SQNL.
        /// </summary>
        public const string A6SQNL = "A6SQNL";

        /// <summary>
        /// A6CRCA.
        /// </summary>
        public const string A6CRCA = "A6CRCA";

        /// <summary>
        /// A6AYPD.
        /// </summary>
        public const string A6AYPD = "A6AYPD";

        /// <summary>
        /// A6APPD.
        /// </summary>
        public const string A6APPD = "A6APPD";

        /// <summary>
        /// A6ABAM.
        /// </summary>
        public const string A6ABAM = "A6ABAM";

        /// <summary>
        /// A6ABA1.
        /// </summary>
        public const string A6ABA1 = "A6ABA1";

        /// <summary>
        /// A6APRC.
        /// </summary>
        public const string A6APRC = "A6APRC";

        /// <summary>
        /// A6MINO.
        /// </summary>
        public const string A6MINO = "A6MINO";

        /// <summary>
        /// A6MAXO.
        /// </summary>
        public const string A6MAXO = "A6MAXO";

        /// <summary>
        /// A6AN8R.
        /// </summary>
        public const string A6AN8R = "A6AN8R";

        /// <summary>
        /// A6BADT.
        /// </summary>
        public const string A6BADT = "A6BADT";

        /// <summary>
        /// A6CPGP.
        /// </summary>
        public const string A6CPGP = "A6CPGP";

        /// <summary>
        /// A6ORTP.
        /// </summary>
        public const string A6ORTP = "A6ORTP";

        /// <summary>
        /// A6INMG.
        /// </summary>
        public const string A6INMG = "A6INMG";

        /// <summary>
        /// A6HOLD.
        /// </summary>
        public const string A6HOLD = "A6HOLD";

        /// <summary>
        /// A6ROUT.
        /// </summary>
        public const string A6ROUT = "A6ROUT";

        /// <summary>
        /// A6STOP.
        /// </summary>
        public const string A6STOP = "A6STOP";

        /// <summary>
        /// A6ZON.
        /// </summary>
        public const string A6ZON = "A6ZON";

        /// <summary>
        /// A6ANCR.
        /// </summary>
        public const string A6ANCR = "A6ANCR";

        /// <summary>
        /// A6CARS.
        /// </summary>
        public const string A6CARS = "A6CARS";

        /// <summary>
        /// A6DEL1.
        /// </summary>
        public const string A6DEL1 = "A6DEL1";

        /// <summary>
        /// A6DEL2.
        /// </summary>
        public const string A6DEL2 = "A6DEL2";

        /// <summary>
        /// A6LTDT.
        /// </summary>
        public const string A6LTDT = "A6LTDT";

        /// <summary>
        /// A6FRTH.
        /// </summary>
        public const string A6FRTH = "A6FRTH";

        /// <summary>
        /// A6INVC.
        /// </summary>
        public const string A6INVC = "A6INVC";

        /// <summary>
        /// A6PLST.
        /// </summary>
        public const string A6PLST = "A6PLST";

        /// <summary>
        /// A6WUMD.
        /// </summary>
        public const string A6WUMD = "A6WUMD";

        /// <summary>
        /// A6VUMD.
        /// </summary>
        public const string A6VUMD = "A6VUMD";

        /// <summary>
        /// A6PRP5.
        /// </summary>
        public const string A6PRP5 = "A6PRP5";

        /// <summary>
        /// A6EDPM.
        /// </summary>
        public const string A6EDPM = "A6EDPM";

        /// <summary>
        /// A6EDCI.
        /// </summary>
        public const string A6EDCI = "A6EDCI";

        /// <summary>
        /// A6EDII.
        /// </summary>
        public const string A6EDII = "A6EDII";

        /// <summary>
        /// A6EDQD.
        /// </summary>
        public const string A6EDQD = "A6EDQD";

        /// <summary>
        /// A6EDAD.
        /// </summary>
        public const string A6EDAD = "A6EDAD";

        /// <summary>
        /// A6EDF1.
        /// </summary>
        public const string A6EDF1 = "A6EDF1";

        /// <summary>
        /// A6EDF2.
        /// </summary>
        public const string A6EDF2 = "A6EDF2";

        /// <summary>
        /// A6VI01.
        /// </summary>
        public const string A6VI01 = "A6VI01";

        /// <summary>
        /// A6VI02.
        /// </summary>
        public const string A6VI02 = "A6VI02";

        /// <summary>
        /// A6VI03.
        /// </summary>
        public const string A6VI03 = "A6VI03";

        /// <summary>
        /// A6VI04.
        /// </summary>
        public const string A6VI04 = "A6VI04";

        /// <summary>
        /// A6VI05.
        /// </summary>
        public const string A6VI05 = "A6VI05";

        /// <summary>
        /// A6MNSC.
        /// </summary>
        public const string A6MNSC = "A6MNSC";

        /// <summary>
        /// A6ATO.
        /// </summary>
        public const string A6ATO = "A6ATO";

        /// <summary>
        /// A6RVNT.
        /// </summary>
        public const string A6RVNT = "A6RVNT";

        /// <summary>
        /// A6URCD.
        /// </summary>
        public const string A6URCD = "A6URCD";

        /// <summary>
        /// A6URDT.
        /// </summary>
        public const string A6URDT = "A6URDT";

        /// <summary>
        /// A6URAT.
        /// </summary>
        public const string A6URAT = "A6URAT";

        /// <summary>
        /// A6URAB.
        /// </summary>
        public const string A6URAB = "A6URAB";

        /// <summary>
        /// A6URRF.
        /// </summary>
        public const string A6URRF = "A6URRF";

        /// <summary>
        /// A6USER.
        /// </summary>
        public const string A6USER = "A6USER";

        /// <summary>
        /// A6PID.
        /// </summary>
        public const string A6PID = "A6PID";

        /// <summary>
        /// A6JOBN.
        /// </summary>
        public const string A6JOBN = "A6JOBN";

        /// <summary>
        /// A6UPMJ.
        /// </summary>
        public const string A6UPMJ = "A6UPMJ";

        /// <summary>
        /// A6UPMT.
        /// </summary>
        public const string A6UPMT = "A6UPMT";

        /// <summary>
        /// A6ASN.
        /// </summary>
        public const string A6ASN = "A6ASN";

        /// <summary>
        /// A6CRMD.
        /// </summary>
        public const string A6CRMD = "A6CRMD";

        /// <summary>
        /// A6AVCH.
        /// </summary>
        public const string A6AVCH = "A6AVCH";

        /// <summary>
        /// A6ATRL.
        /// </summary>
        public const string A6ATRL = "A6ATRL";
    }

    /// <inheritdoc />
    public override string TableName => "F0401";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("A6AN8", "A6AN8", JdeDataType.Numeric, null, true, true),
        new JdeField("A6APC", "A6APC", JdeDataType.String, 8),
        new JdeField("A6MCUP", "A6MCUP", JdeDataType.String, 24),
        new JdeField("A6OBAP", "A6OBAP", JdeDataType.String, 12),
        new JdeField("A6AIDP", "A6AIDP", JdeDataType.String, 16),
        new JdeField("A6KCOP", "A6KCOP", JdeDataType.String, 10),
        new JdeField("A6DCAP", "A6DCAP", JdeDataType.Numeric),
        new JdeField("A6DTAP", "A6DTAP", JdeDataType.String, 4),
        new JdeField("A6CRRP", "A6CRRP", JdeDataType.String, 6),
        new JdeField("A6TXA2", "A6TXA2", JdeDataType.String, 20),
        new JdeField("A6EXR2", "A6EXR2", JdeDataType.String, 4),
        new JdeField("A6HDPY", "A6HDPY", JdeDataType.String, 2),
        new JdeField("A6TXA3", "A6TXA3", JdeDataType.String, 20),
        new JdeField("A6EXR3", "A6EXR3", JdeDataType.String, 4),
        new JdeField("A6TAWH", "A6TAWH", JdeDataType.Numeric),
        new JdeField("A6PCWH", "A6PCWH", JdeDataType.Numeric),
        new JdeField("A6TRAP", "A6TRAP", JdeDataType.String, 6),
        new JdeField("A6SCK", "A6SCK", JdeDataType.String, 2),
        new JdeField("A6PYIN", "A6PYIN", JdeDataType.String, 2),
        new JdeField("A6SNTO", "A6SNTO", JdeDataType.Numeric),
        new JdeField("A6AB1", "A6AB1", JdeDataType.String, 2),
        new JdeField("A6FLD", "A6FLD", JdeDataType.Numeric),
        new JdeField("A6SQNL", "A6SQNL", JdeDataType.String, 2),
        new JdeField("A6CRCA", "A6CRCA", JdeDataType.String, 6),
        new JdeField("A6AYPD", "A6AYPD", JdeDataType.Numeric),
        new JdeField("A6APPD", "A6APPD", JdeDataType.Numeric),
        new JdeField("A6ABAM", "A6ABAM", JdeDataType.Numeric),
        new JdeField("A6ABA1", "A6ABA1", JdeDataType.Numeric),
        new JdeField("A6APRC", "A6APRC", JdeDataType.Numeric),
        new JdeField("A6MINO", "A6MINO", JdeDataType.Numeric),
        new JdeField("A6MAXO", "A6MAXO", JdeDataType.Numeric),
        new JdeField("A6AN8R", "A6AN8R", JdeDataType.Numeric),
        new JdeField("A6BADT", "A6BADT", JdeDataType.String, 2),
        new JdeField("A6CPGP", "A6CPGP", JdeDataType.String, 16),
        new JdeField("A6ORTP", "A6ORTP", JdeDataType.String, 16),
        new JdeField("A6INMG", "A6INMG", JdeDataType.String, 20),
        new JdeField("A6HOLD", "A6HOLD", JdeDataType.String, 4),
        new JdeField("A6ROUT", "A6ROUT", JdeDataType.String, 6),
        new JdeField("A6STOP", "A6STOP", JdeDataType.String, 6),
        new JdeField("A6ZON", "A6ZON", JdeDataType.String, 6),
        new JdeField("A6ANCR", "A6ANCR", JdeDataType.Numeric),
        new JdeField("A6CARS", "A6CARS", JdeDataType.Numeric),
        new JdeField("A6DEL1", "A6DEL1", JdeDataType.String, 60),
        new JdeField("A6DEL2", "A6DEL2", JdeDataType.String, 60),
        new JdeField("A6LTDT", "A6LTDT", JdeDataType.Numeric),
        new JdeField("A6FRTH", "A6FRTH", JdeDataType.String, 6),
        new JdeField("A6INVC", "A6INVC", JdeDataType.Numeric),
        new JdeField("A6PLST", "A6PLST", JdeDataType.String, 2),
        new JdeField("A6WUMD", "A6WUMD", JdeDataType.String, 4),
        new JdeField("A6VUMD", "A6VUMD", JdeDataType.String, 4),
        new JdeField("A6PRP5", "A6PRP5", JdeDataType.String, 6),
        new JdeField("A6EDPM", "A6EDPM", JdeDataType.String, 2),
        new JdeField("A6EDCI", "A6EDCI", JdeDataType.String, 2),
        new JdeField("A6EDII", "A6EDII", JdeDataType.String, 2),
        new JdeField("A6EDQD", "A6EDQD", JdeDataType.Numeric),
        new JdeField("A6EDAD", "A6EDAD", JdeDataType.Numeric),
        new JdeField("A6EDF1", "A6EDF1", JdeDataType.String, 2),
        new JdeField("A6EDF2", "A6EDF2", JdeDataType.String, 2),
        new JdeField("A6VI01", "A6VI01", JdeDataType.String, 2),
        new JdeField("A6VI02", "A6VI02", JdeDataType.String, 2),
        new JdeField("A6VI03", "A6VI03", JdeDataType.String, 2),
        new JdeField("A6VI04", "A6VI04", JdeDataType.String, 2),
        new JdeField("A6VI05", "A6VI05", JdeDataType.String, 2),
        new JdeField("A6MNSC", "A6MNSC", JdeDataType.String, 2),
        new JdeField("A6ATO", "A6ATO", JdeDataType.String, 2),
        new JdeField("A6RVNT", "A6RVNT", JdeDataType.String, 2),
        new JdeField("A6URCD", "A6URCD", JdeDataType.String, 4),
        new JdeField("A6URDT", "A6URDT", JdeDataType.Numeric),
        new JdeField("A6URAT", "A6URAT", JdeDataType.Numeric),
        new JdeField("A6URAB", "A6URAB", JdeDataType.Numeric),
        new JdeField("A6URRF", "A6URRF", JdeDataType.String, 30),
        new JdeField("A6USER", "A6USER", JdeDataType.String, 20),
        new JdeField("A6PID", "A6PID", JdeDataType.String, 20),
        new JdeField("A6JOBN", "A6JOBN", JdeDataType.String, 20),
        new JdeField("A6UPMJ", "A6UPMJ", JdeDataType.Numeric),
        new JdeField("A6UPMT", "A6UPMT", JdeDataType.Numeric),
        new JdeField("A6ASN", "A6ASN", JdeDataType.String, 16),
        new JdeField("A6CRMD", "A6CRMD", JdeDataType.String, 2),
        new JdeField("A6AVCH", "A6AVCH", JdeDataType.String, 2),
        new JdeField("A6ATRL", "A6ATRL", JdeDataType.String, 4)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F0401_0", "Primary Key on A6AN8", new[] { "A6AN8" }, isUnique: true, isPrimaryKey: true)
    };
}
