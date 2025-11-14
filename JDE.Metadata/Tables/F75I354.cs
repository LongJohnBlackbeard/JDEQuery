using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75I354 - .
/// </summary>
public class F75I354 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// QWYEXU.
        /// </summary>
        public const string QWYEXU = "QWYEXU";

        /// <summary>
        /// QWYAR3N.
        /// </summary>
        public const string QWYAR3N = "QWYAR3N";

        /// <summary>
        /// QWYSUF.
        /// </summary>
        public const string QWYSUF = "QWYSUF";

        /// <summary>
        /// QWYARD.
        /// </summary>
        public const string QWYARD = "QWYARD";

        /// <summary>
        /// QWAST.
        /// </summary>
        public const string QWAST = "QWAST";

        /// <summary>
        /// QWYAR3D.
        /// </summary>
        public const string QWYAR3D = "QWYAR3D";

        /// <summary>
        /// QWDOCO.
        /// </summary>
        public const string QWDOCO = "QWDOCO";

        /// <summary>
        /// QWDCTO.
        /// </summary>
        public const string QWDCTO = "QWDCTO";

        /// <summary>
        /// QWKCOO.
        /// </summary>
        public const string QWKCOO = "QWKCOO";

        /// <summary>
        /// QWDOC.
        /// </summary>
        public const string QWDOC = "QWDOC";

        /// <summary>
        /// QWDCT.
        /// </summary>
        public const string QWDCT = "QWDCT";

        /// <summary>
        /// QWKCO.
        /// </summary>
        public const string QWKCO = "QWKCO";

        /// <summary>
        /// QWASVL.
        /// </summary>
        public const string QWASVL = "QWASVL";

        /// <summary>
        /// QWMOT.
        /// </summary>
        public const string QWMOT = "QWMOT";

        /// <summary>
        /// QWYIAM.
        /// </summary>
        public const string QWYIAM = "QWYIAM";

        /// <summary>
        /// QWFLG.
        /// </summary>
        public const string QWFLG = "QWFLG";

        /// <summary>
        /// QWYA3D.
        /// </summary>
        public const string QWYA3D = "QWYA3D";

        /// <summary>
        /// QWATDJ.
        /// </summary>
        public const string QWATDJ = "QWATDJ";

        /// <summary>
        /// QWFVTR.
        /// </summary>
        public const string QWFVTR = "QWFVTR";

        /// <summary>
        /// QWI75TAXA.
        /// </summary>
        public const string QWI75TAXA = "QWI75TAXA";

        /// <summary>
        /// QWI75TXR.
        /// </summary>
        public const string QWI75TXR = "QWI75TXR";

        /// <summary>
        /// QWI75TXRG.
        /// </summary>
        public const string QWI75TXRG = "QWI75TXRG";

        /// <summary>
        /// QWI75TXTY.
        /// </summary>
        public const string QWI75TXTY = "QWI75TXTY";

        /// <summary>
        /// QWAA1.
        /// </summary>
        public const string QWAA1 = "QWAA1";

        /// <summary>
        /// QWAA2.
        /// </summary>
        public const string QWAA2 = "QWAA2";

        /// <summary>
        /// QWAA3.
        /// </summary>
        public const string QWAA3 = "QWAA3";

        /// <summary>
        /// QWDL01.
        /// </summary>
        public const string QWDL01 = "QWDL01";

        /// <summary>
        /// QWDS01.
        /// </summary>
        public const string QWDS01 = "QWDS01";

        /// <summary>
        /// QWDTE.
        /// </summary>
        public const string QWDTE = "QWDTE";

        /// <summary>
        /// QWFLAG.
        /// </summary>
        public const string QWFLAG = "QWFLAG";

        /// <summary>
        /// QWFFU2.
        /// </summary>
        public const string QWFFU2 = "QWFFU2";

        /// <summary>
        /// QWUSER.
        /// </summary>
        public const string QWUSER = "QWUSER";

        /// <summary>
        /// QWJOBN.
        /// </summary>
        public const string QWJOBN = "QWJOBN";

        /// <summary>
        /// QWUPMJ.
        /// </summary>
        public const string QWUPMJ = "QWUPMJ";

        /// <summary>
        /// QWUPMT.
        /// </summary>
        public const string QWUPMT = "QWUPMT";

        /// <summary>
        /// QWPID.
        /// </summary>
        public const string QWPID = "QWPID";
    }

    /// <inheritdoc />
    public override string TableName => "F75I354";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("QWYEXU", "QWYEXU", JdeDataType.Numeric, null, true, true),
        new JdeField("QWYAR3N", "QWYAR3N", JdeDataType.Numeric, null, true, true),
        new JdeField("QWYSUF", "QWYSUF", JdeDataType.String, 4, true, true),
        new JdeField("QWYARD", "QWYARD", JdeDataType.Numeric, null, true, true),
        new JdeField("QWAST", "QWAST", JdeDataType.String, 16, true, true),
        new JdeField("QWYAR3D", "QWYAR3D", JdeDataType.Numeric),
        new JdeField("QWDOCO", "QWDOCO", JdeDataType.Numeric),
        new JdeField("QWDCTO", "QWDCTO", JdeDataType.String, 4),
        new JdeField("QWKCOO", "QWKCOO", JdeDataType.String, 10),
        new JdeField("QWDOC", "QWDOC", JdeDataType.Numeric),
        new JdeField("QWDCT", "QWDCT", JdeDataType.String, 4),
        new JdeField("QWKCO", "QWKCO", JdeDataType.String, 10),
        new JdeField("QWASVL", "QWASVL", JdeDataType.Numeric),
        new JdeField("QWMOT", "QWMOT", JdeDataType.String, 6),
        new JdeField("QWYIAM", "QWYIAM", JdeDataType.Numeric),
        new JdeField("QWFLG", "QWFLG", JdeDataType.String, 2),
        new JdeField("QWYA3D", "QWYA3D", JdeDataType.Numeric),
        new JdeField("QWATDJ", "QWATDJ", JdeDataType.Numeric),
        new JdeField("QWFVTR", "QWFVTR", JdeDataType.Numeric),
        new JdeField("QWI75TAXA", "QWI75TAXA", JdeDataType.Numeric),
        new JdeField("QWI75TXR", "QWI75TXR", JdeDataType.Numeric),
        new JdeField("QWI75TXRG", "QWI75TXRG", JdeDataType.String, 10),
        new JdeField("QWI75TXTY", "QWI75TXTY", JdeDataType.String, 10),
        new JdeField("QWAA1", "QWAA1", JdeDataType.Numeric),
        new JdeField("QWAA2", "QWAA2", JdeDataType.Numeric),
        new JdeField("QWAA3", "QWAA3", JdeDataType.Numeric),
        new JdeField("QWDL01", "QWDL01", JdeDataType.String, 60),
        new JdeField("QWDS01", "QWDS01", JdeDataType.String, 160),
        new JdeField("QWDTE", "QWDTE", JdeDataType.Numeric),
        new JdeField("QWFLAG", "QWFLAG", JdeDataType.String, 2),
        new JdeField("QWFFU2", "QWFFU2", JdeDataType.String, 2),
        new JdeField("QWUSER", "QWUSER", JdeDataType.String, 20),
        new JdeField("QWJOBN", "QWJOBN", JdeDataType.String, 20),
        new JdeField("QWUPMJ", "QWUPMJ", JdeDataType.Numeric),
        new JdeField("QWUPMT", "QWUPMT", JdeDataType.Numeric),
        new JdeField("QWPID", "QWPID", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75I354_0", "Primary Key on QWYEXU, QWYAR3N, QWYSUF, QWYARD, QWAST", new[] { "QWYEXU", "QWYAR3N", "QWYSUF", "QWYARD", "QWAST" }, isUnique: true, isPrimaryKey: true)
    };
}
