using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F46L12 - .
/// </summary>
public class F46L12 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// LCUKID.
        /// </summary>
        public const string LCUKID = "LCUKID";

        /// <summary>
        /// LCDOCO.
        /// </summary>
        public const string LCDOCO = "LCDOCO";

        /// <summary>
        /// LCDCTO.
        /// </summary>
        public const string LCDCTO = "LCDCTO";

        /// <summary>
        /// LCKCOO.
        /// </summary>
        public const string LCKCOO = "LCKCOO";

        /// <summary>
        /// LCLNID.
        /// </summary>
        public const string LCLNID = "LCLNID";

        /// <summary>
        /// LCSFXO.
        /// </summary>
        public const string LCSFXO = "LCSFXO";

        /// <summary>
        /// LCSGBT.
        /// </summary>
        public const string LCSGBT = "LCSGBT";

        /// <summary>
        /// LCSGSQ.
        /// </summary>
        public const string LCSGSQ = "LCSGSQ";

        /// <summary>
        /// LCUK01.
        /// </summary>
        public const string LCUK01 = "LCUK01";

        /// <summary>
        /// LCPRJM.
        /// </summary>
        public const string LCPRJM = "LCPRJM";

        /// <summary>
        /// LCLPNU.
        /// </summary>
        public const string LCLPNU = "LCLPNU";

        /// <summary>
        /// LCMCU.
        /// </summary>
        public const string LCMCU = "LCMCU";

        /// <summary>
        /// LCITM.
        /// </summary>
        public const string LCITM = "LCITM";

        /// <summary>
        /// LCLOCN.
        /// </summary>
        public const string LCLOCN = "LCLOCN";

        /// <summary>
        /// LCLOTN.
        /// </summary>
        public const string LCLOTN = "LCLOTN";

        /// <summary>
        /// LCMMEJ.
        /// </summary>
        public const string LCMMEJ = "LCMMEJ";

        /// <summary>
        /// LCCMTYP.
        /// </summary>
        public const string LCCMTYP = "LCCMTYP";

        /// <summary>
        /// LCQCOM.
        /// </summary>
        public const string LCQCOM = "LCQCOM";

        /// <summary>
        /// LCUOMC.
        /// </summary>
        public const string LCUOMC = "LCUOMC";

        /// <summary>
        /// LCLPNDC.
        /// </summary>
        public const string LCLPNDC = "LCLPNDC";

        /// <summary>
        /// LCUSER.
        /// </summary>
        public const string LCUSER = "LCUSER";

        /// <summary>
        /// LCPID.
        /// </summary>
        public const string LCPID = "LCPID";

        /// <summary>
        /// LCMKEY.
        /// </summary>
        public const string LCMKEY = "LCMKEY";

        /// <summary>
        /// LCURCD.
        /// </summary>
        public const string LCURCD = "LCURCD";

        /// <summary>
        /// LCURDT.
        /// </summary>
        public const string LCURDT = "LCURDT";

        /// <summary>
        /// LCURAB.
        /// </summary>
        public const string LCURAB = "LCURAB";

        /// <summary>
        /// LCURRF.
        /// </summary>
        public const string LCURRF = "LCURRF";

        /// <summary>
        /// LCUPMJ.
        /// </summary>
        public const string LCUPMJ = "LCUPMJ";

        /// <summary>
        /// LCTDAY.
        /// </summary>
        public const string LCTDAY = "LCTDAY";

        /// <summary>
        /// LCSVRNAME.
        /// </summary>
        public const string LCSVRNAME = "LCSVRNAME";
    }

    /// <inheritdoc />
    public override string TableName => "F46L12";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("LCUKID", "LCUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("LCDOCO", "LCDOCO", JdeDataType.Numeric),
        new JdeField("LCDCTO", "LCDCTO", JdeDataType.String, 4),
        new JdeField("LCKCOO", "LCKCOO", JdeDataType.String, 10),
        new JdeField("LCLNID", "LCLNID", JdeDataType.Numeric),
        new JdeField("LCSFXO", "LCSFXO", JdeDataType.String, 6),
        new JdeField("LCSGBT", "LCSGBT", JdeDataType.Numeric),
        new JdeField("LCSGSQ", "LCSGSQ", JdeDataType.Numeric),
        new JdeField("LCUK01", "LCUK01", JdeDataType.Numeric),
        new JdeField("LCPRJM", "LCPRJM", JdeDataType.Numeric),
        new JdeField("LCLPNU", "LCLPNU", JdeDataType.String, 80),
        new JdeField("LCMCU", "LCMCU", JdeDataType.String, 24),
        new JdeField("LCITM", "LCITM", JdeDataType.Numeric),
        new JdeField("LCLOCN", "LCLOCN", JdeDataType.String, 40),
        new JdeField("LCLOTN", "LCLOTN", JdeDataType.String, 60),
        new JdeField("LCMMEJ", "LCMMEJ", JdeDataType.Numeric),
        new JdeField("LCCMTYP", "LCCMTYP", JdeDataType.String, 4),
        new JdeField("LCQCOM", "LCQCOM", JdeDataType.Numeric),
        new JdeField("LCUOMC", "LCUOMC", JdeDataType.String, 4),
        new JdeField("LCLPNDC", "LCLPNDC", JdeDataType.Date),
        new JdeField("LCUSER", "LCUSER", JdeDataType.String, 20),
        new JdeField("LCPID", "LCPID", JdeDataType.String, 20),
        new JdeField("LCMKEY", "LCMKEY", JdeDataType.String, 30),
        new JdeField("LCURCD", "LCURCD", JdeDataType.String, 4),
        new JdeField("LCURDT", "LCURDT", JdeDataType.Numeric),
        new JdeField("LCURAB", "LCURAB", JdeDataType.Numeric),
        new JdeField("LCURRF", "LCURRF", JdeDataType.String, 30),
        new JdeField("LCUPMJ", "LCUPMJ", JdeDataType.Numeric),
        new JdeField("LCTDAY", "LCTDAY", JdeDataType.Numeric),
        new JdeField("LCSVRNAME", "LCSVRNAME", JdeDataType.String, 30)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F46L12_0", "Primary Key on LCUKID", new[] { "LCUKID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F46L12_2", "Index on LCDOCO, LCDCTO, LCKCOO, LCLNID, LCSFXO", new[] { "LCDOCO", "LCDCTO", "LCKCOO", "LCLNID", "LCSFXO" }),
        new JdeIndex("F46L12_3", "Index on LCSGBT, LCSGSQ", new[] { "LCSGBT", "LCSGSQ" }),
        new JdeIndex("F46L12_4", "Index on LCUK01", new[] { "LCUK01" }),
        new JdeIndex("F46L12_5", "Index on LCLPNU, LCITM, LCLOTN", new[] { "LCLPNU", "LCITM", "LCLOTN" }),
        new JdeIndex("F46L12_6", "Index on LCLPNU", new[] { "LCLPNU" }),
        new JdeIndex("F46L12_7", "Index on LCSGBT, LCSGSQ, LCLPNU, LCITM, LCLOTN", new[] { "LCSGBT", "LCSGSQ", "LCLPNU", "LCITM", "LCLOTN" }),
        new JdeIndex("F46L12_8", "Index on LCMCU, LCITM, LCCMTYP, LCUOMC", new[] { "LCMCU", "LCITM", "LCCMTYP", "LCUOMC" })
    };
}
