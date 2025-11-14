using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74Y060 - .
/// </summary>
public class F74Y060 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// YSCO.
        /// </summary>
        public const string YSCO = "YSCO";

        /// <summary>
        /// YSY74DYR.
        /// </summary>
        public const string YSY74DYR = "YSY74DYR";

        /// <summary>
        /// YSY74DPER.
        /// </summary>
        public const string YSY74DPER = "YSY74DPER";

        /// <summary>
        /// YSY74DPN.
        /// </summary>
        public const string YSY74DPN = "YSY74DPN";

        /// <summary>
        /// YSY74TPUL.
        /// </summary>
        public const string YSY74TPUL = "YSY74TPUL";

        /// <summary>
        /// YSI74SCOD.
        /// </summary>
        public const string YSI74SCOD = "YSI74SCOD";

        /// <summary>
        /// YSAN8.
        /// </summary>
        public const string YSAN8 = "YSAN8";

        /// <summary>
        /// YSI74RELE.
        /// </summary>
        public const string YSI74RELE = "YSI74RELE";

        /// <summary>
        /// YSI74RDOF.
        /// </summary>
        public const string YSI74RDOF = "YSI74RDOF";

        /// <summary>
        /// YSTX2.
        /// </summary>
        public const string YSTX2 = "YSTX2";

        /// <summary>
        /// YSTAX.
        /// </summary>
        public const string YSTAX = "YSTAX";

        /// <summary>
        /// YSI74QPT.
        /// </summary>
        public const string YSI74QPT = "YSI74QPT";

        /// <summary>
        /// YSI74QNT.
        /// </summary>
        public const string YSI74QNT = "YSI74QNT";

        /// <summary>
        /// YSI74PAEX.
        /// </summary>
        public const string YSI74PAEX = "YSI74PAEX";

        /// <summary>
        /// YSI74PSTM.
        /// </summary>
        public const string YSI74PSTM = "YSI74PSTM";

        /// <summary>
        /// YSI74PANE.
        /// </summary>
        public const string YSI74PANE = "YSI74PANE";

        /// <summary>
        /// YSI74PTAN.
        /// </summary>
        public const string YSI74PTAN = "YSI74PTAN";

        /// <summary>
        /// YSI74PVAN.
        /// </summary>
        public const string YSI74PVAN = "YSI74PVAN";

        /// <summary>
        /// YSI74NAEX.
        /// </summary>
        public const string YSI74NAEX = "YSI74NAEX";

        /// <summary>
        /// YSI74NSTM.
        /// </summary>
        public const string YSI74NSTM = "YSI74NSTM";

        /// <summary>
        /// YSI74NANE.
        /// </summary>
        public const string YSI74NANE = "YSI74NANE";

        /// <summary>
        /// YSI74NTAN.
        /// </summary>
        public const string YSI74NTAN = "YSI74NTAN";

        /// <summary>
        /// YSI74NVAN.
        /// </summary>
        public const string YSI74NVAN = "YSI74NVAN";

        /// <summary>
        /// YSI74TOAM.
        /// </summary>
        public const string YSI74TOAM = "YSI74TOAM";

        /// <summary>
        /// YSI74PSGA.
        /// </summary>
        public const string YSI74PSGA = "YSI74PSGA";

        /// <summary>
        /// YSI74PSSA.
        /// </summary>
        public const string YSI74PSSA = "YSI74PSSA";

        /// <summary>
        /// YSI74NTNV.
        /// </summary>
        public const string YSI74NTNV = "YSI74NTNV";

        /// <summary>
        /// YSI74PSNR.
        /// </summary>
        public const string YSI74PSNR = "YSI74PSNR";

        /// <summary>
        /// YSCRCD.
        /// </summary>
        public const string YSCRCD = "YSCRCD";

        /// <summary>
        /// YSUSER.
        /// </summary>
        public const string YSUSER = "YSUSER";

        /// <summary>
        /// YSJOBN.
        /// </summary>
        public const string YSJOBN = "YSJOBN";

        /// <summary>
        /// YSPID.
        /// </summary>
        public const string YSPID = "YSPID";

        /// <summary>
        /// YSUPMJ.
        /// </summary>
        public const string YSUPMJ = "YSUPMJ";

        /// <summary>
        /// YSUPMT.
        /// </summary>
        public const string YSUPMT = "YSUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F74Y060";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("YSCO", "YSCO", JdeDataType.String, 10, true, true),
        new JdeField("YSY74DYR", "YSY74DYR", JdeDataType.Numeric, null, true, true),
        new JdeField("YSY74DPER", "YSY74DPER", JdeDataType.String, 2, true, true),
        new JdeField("YSY74DPN", "YSY74DPN", JdeDataType.Numeric, null, true, true),
        new JdeField("YSY74TPUL", "YSY74TPUL", JdeDataType.String, 2, true, true),
        new JdeField("YSI74SCOD", "YSI74SCOD", JdeDataType.Numeric, null, true, true),
        new JdeField("YSAN8", "YSAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("YSI74RELE", "YSI74RELE", JdeDataType.String, 4, true, true),
        new JdeField("YSI74RDOF", "YSI74RDOF", JdeDataType.String, 2, true, true),
        new JdeField("YSTX2", "YSTX2", JdeDataType.String, 40),
        new JdeField("YSTAX", "YSTAX", JdeDataType.String, 40),
        new JdeField("YSI74QPT", "YSI74QPT", JdeDataType.Numeric),
        new JdeField("YSI74QNT", "YSI74QNT", JdeDataType.Numeric),
        new JdeField("YSI74PAEX", "YSI74PAEX", JdeDataType.Numeric),
        new JdeField("YSI74PSTM", "YSI74PSTM", JdeDataType.Numeric),
        new JdeField("YSI74PANE", "YSI74PANE", JdeDataType.Numeric),
        new JdeField("YSI74PTAN", "YSI74PTAN", JdeDataType.Numeric),
        new JdeField("YSI74PVAN", "YSI74PVAN", JdeDataType.Numeric),
        new JdeField("YSI74NAEX", "YSI74NAEX", JdeDataType.Numeric),
        new JdeField("YSI74NSTM", "YSI74NSTM", JdeDataType.Numeric),
        new JdeField("YSI74NANE", "YSI74NANE", JdeDataType.Numeric),
        new JdeField("YSI74NTAN", "YSI74NTAN", JdeDataType.Numeric),
        new JdeField("YSI74NVAN", "YSI74NVAN", JdeDataType.Numeric),
        new JdeField("YSI74TOAM", "YSI74TOAM", JdeDataType.Numeric),
        new JdeField("YSI74PSGA", "YSI74PSGA", JdeDataType.Numeric),
        new JdeField("YSI74PSSA", "YSI74PSSA", JdeDataType.Numeric),
        new JdeField("YSI74NTNV", "YSI74NTNV", JdeDataType.Numeric),
        new JdeField("YSI74PSNR", "YSI74PSNR", JdeDataType.Numeric),
        new JdeField("YSCRCD", "YSCRCD", JdeDataType.String, 6),
        new JdeField("YSUSER", "YSUSER", JdeDataType.String, 20),
        new JdeField("YSJOBN", "YSJOBN", JdeDataType.String, 20),
        new JdeField("YSPID", "YSPID", JdeDataType.String, 20),
        new JdeField("YSUPMJ", "YSUPMJ", JdeDataType.Numeric),
        new JdeField("YSUPMT", "YSUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74Y060_0", "Primary Key on YSCO, YSY74DYR, YSY74DPER, YSY74DPN, YSY74TPUL, YSI74SCOD, YSAN8, YSI74RELE, YSI74RDOF", new[] { "YSCO", "YSY74DYR", "YSY74DPER", "YSY74DPN", "YSY74TPUL", "YSI74SCOD", "YSAN8", "YSI74RELE", "YSI74RDOF" }, isUnique: true, isPrimaryKey: true)
    };
}
