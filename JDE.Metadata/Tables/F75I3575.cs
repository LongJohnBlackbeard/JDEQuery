using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75I3575 - .
/// </summary>
public class F75I3575 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CPDOCO.
        /// </summary>
        public const string CPDOCO = "CPDOCO";

        /// <summary>
        /// CPDCTO.
        /// </summary>
        public const string CPDCTO = "CPDCTO";

        /// <summary>
        /// CPKCOO.
        /// </summary>
        public const string CPKCOO = "CPKCOO";

        /// <summary>
        /// CPITM.
        /// </summary>
        public const string CPITM = "CPITM";

        /// <summary>
        /// CPLITM.
        /// </summary>
        public const string CPLITM = "CPLITM";

        /// <summary>
        /// CPTRQT.
        /// </summary>
        public const string CPTRQT = "CPTRQT";

        /// <summary>
        /// CPUOM.
        /// </summary>
        public const string CPUOM = "CPUOM";

        /// <summary>
        /// CPUREC.
        /// </summary>
        public const string CPUREC = "CPUREC";

        /// <summary>
        /// CPQBAL.
        /// </summary>
        public const string CPQBAL = "CPQBAL";

        /// <summary>
        /// CPPRFR.
        /// </summary>
        public const string CPPRFR = "CPPRFR";

        /// <summary>
        /// CPUMGP.
        /// </summary>
        public const string CPUMGP = "CPUMGP";

        /// <summary>
        /// CPAQTY.
        /// </summary>
        public const string CPAQTY = "CPAQTY";

        /// <summary>
        /// CPASVL.
        /// </summary>
        public const string CPASVL = "CPASVL";

        /// <summary>
        /// CPYTDU.
        /// </summary>
        public const string CPYTDU = "CPYTDU";

        /// <summary>
        /// CPDTYS.
        /// </summary>
        public const string CPDTYS = "CPDTYS";

        /// <summary>
        /// CPFLAG.
        /// </summary>
        public const string CPFLAG = "CPFLAG";

        /// <summary>
        /// CPASID.
        /// </summary>
        public const string CPASID = "CPASID";

        /// <summary>
        /// CPUFLG.
        /// </summary>
        public const string CPUFLG = "CPUFLG";

        /// <summary>
        /// CPQTY1.
        /// </summary>
        public const string CPQTY1 = "CPQTY1";

        /// <summary>
        /// CPQTY2.
        /// </summary>
        public const string CPQTY2 = "CPQTY2";

        /// <summary>
        /// CPCRCD.
        /// </summary>
        public const string CPCRCD = "CPCRCD";

        /// <summary>
        /// CPCRDC.
        /// </summary>
        public const string CPCRDC = "CPCRDC";

        /// <summary>
        /// CPYUTD.
        /// </summary>
        public const string CPYUTD = "CPYUTD";

        /// <summary>
        /// CPLFDJ.
        /// </summary>
        public const string CPLFDJ = "CPLFDJ";

        /// <summary>
        /// CPPSDJ.
        /// </summary>
        public const string CPPSDJ = "CPPSDJ";

        /// <summary>
        /// CPDT.
        /// </summary>
        public const string CPDT = "CPDT";

        /// <summary>
        /// CPDT1.
        /// </summary>
        public const string CPDT1 = "CPDT1";

        /// <summary>
        /// CPF1A.
        /// </summary>
        public const string CPF1A = "CPF1A";

        /// <summary>
        /// CPF2A.
        /// </summary>
        public const string CPF2A = "CPF2A";

        /// <summary>
        /// CPF3A.
        /// </summary>
        public const string CPF3A = "CPF3A";

        /// <summary>
        /// CPF4A.
        /// </summary>
        public const string CPF4A = "CPF4A";

        /// <summary>
        /// CPC1FU.
        /// </summary>
        public const string CPC1FU = "CPC1FU";

        /// <summary>
        /// CPC2FU.
        /// </summary>
        public const string CPC2FU = "CPC2FU";

        /// <summary>
        /// CPOPT.
        /// </summary>
        public const string CPOPT = "CPOPT";

        /// <summary>
        /// CPF1T.
        /// </summary>
        public const string CPF1T = "CPF1T";

        /// <summary>
        /// CPF2T.
        /// </summary>
        public const string CPF2T = "CPF2T";

        /// <summary>
        /// CPF3T.
        /// </summary>
        public const string CPF3T = "CPF3T";

        /// <summary>
        /// CPACC.
        /// </summary>
        public const string CPACC = "CPACC";

        /// <summary>
        /// CPANS.
        /// </summary>
        public const string CPANS = "CPANS";

        /// <summary>
        /// CPPID.
        /// </summary>
        public const string CPPID = "CPPID";

        /// <summary>
        /// CPUSER.
        /// </summary>
        public const string CPUSER = "CPUSER";

        /// <summary>
        /// CPJOBN.
        /// </summary>
        public const string CPJOBN = "CPJOBN";

        /// <summary>
        /// CPUPMJ.
        /// </summary>
        public const string CPUPMJ = "CPUPMJ";

        /// <summary>
        /// CPUPMT.
        /// </summary>
        public const string CPUPMT = "CPUPMT";

        /// <summary>
        /// CPEF01.
        /// </summary>
        public const string CPEF01 = "CPEF01";
    }

    /// <inheritdoc />
    public override string TableName => "F75I3575";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CPDOCO", "CPDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("CPDCTO", "CPDCTO", JdeDataType.String, 4, true, true),
        new JdeField("CPKCOO", "CPKCOO", JdeDataType.String, 10, true, true),
        new JdeField("CPITM", "CPITM", JdeDataType.Numeric, null, true, true),
        new JdeField("CPLITM", "CPLITM", JdeDataType.String, 50),
        new JdeField("CPTRQT", "CPTRQT", JdeDataType.Numeric),
        new JdeField("CPUOM", "CPUOM", JdeDataType.String, 4),
        new JdeField("CPUREC", "CPUREC", JdeDataType.Numeric),
        new JdeField("CPQBAL", "CPQBAL", JdeDataType.Numeric),
        new JdeField("CPPRFR", "CPPRFR", JdeDataType.String, 4),
        new JdeField("CPUMGP", "CPUMGP", JdeDataType.String, 4),
        new JdeField("CPAQTY", "CPAQTY", JdeDataType.Numeric),
        new JdeField("CPASVL", "CPASVL", JdeDataType.Numeric),
        new JdeField("CPYTDU", "CPYTDU", JdeDataType.Numeric),
        new JdeField("CPDTYS", "CPDTYS", JdeDataType.String, 4),
        new JdeField("CPFLAG", "CPFLAG", JdeDataType.String, 2),
        new JdeField("CPASID", "CPASID", JdeDataType.String, 50),
        new JdeField("CPUFLG", "CPUFLG", JdeDataType.String, 2),
        new JdeField("CPQTY1", "CPQTY1", JdeDataType.Numeric),
        new JdeField("CPQTY2", "CPQTY2", JdeDataType.Numeric),
        new JdeField("CPCRCD", "CPCRCD", JdeDataType.String, 6),
        new JdeField("CPCRDC", "CPCRDC", JdeDataType.String, 6),
        new JdeField("CPYUTD", "CPYUTD", JdeDataType.Numeric),
        new JdeField("CPLFDJ", "CPLFDJ", JdeDataType.Numeric),
        new JdeField("CPPSDJ", "CPPSDJ", JdeDataType.Numeric),
        new JdeField("CPDT", "CPDT", JdeDataType.Numeric),
        new JdeField("CPDT1", "CPDT1", JdeDataType.Numeric),
        new JdeField("CPF1A", "CPF1A", JdeDataType.Numeric),
        new JdeField("CPF2A", "CPF2A", JdeDataType.Numeric),
        new JdeField("CPF3A", "CPF3A", JdeDataType.Numeric),
        new JdeField("CPF4A", "CPF4A", JdeDataType.Numeric),
        new JdeField("CPC1FU", "CPC1FU", JdeDataType.String, 2),
        new JdeField("CPC2FU", "CPC2FU", JdeDataType.String, 2),
        new JdeField("CPOPT", "CPOPT", JdeDataType.String, 2),
        new JdeField("CPF1T", "CPF1T", JdeDataType.String, 60),
        new JdeField("CPF2T", "CPF2T", JdeDataType.String, 60),
        new JdeField("CPF3T", "CPF3T", JdeDataType.String, 60),
        new JdeField("CPACC", "CPACC", JdeDataType.String, 32),
        new JdeField("CPANS", "CPANS", JdeDataType.String, 50),
        new JdeField("CPPID", "CPPID", JdeDataType.String, 20),
        new JdeField("CPUSER", "CPUSER", JdeDataType.String, 20),
        new JdeField("CPJOBN", "CPJOBN", JdeDataType.String, 20),
        new JdeField("CPUPMJ", "CPUPMJ", JdeDataType.Numeric),
        new JdeField("CPUPMT", "CPUPMT", JdeDataType.Numeric),
        new JdeField("CPEF01", "CPEF01", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75I3575_0", "Primary Key on CPKCOO, CPDOCO, CPDCTO, CPITM", new[] { "CPKCOO", "CPDOCO", "CPDCTO", "CPITM" }, isUnique: true, isPrimaryKey: true)
    };
}
