using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75I735 - .
/// </summary>
public class F75I735 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// STDOCO.
        /// </summary>
        public const string STDOCO = "STDOCO";

        /// <summary>
        /// STKCOO.
        /// </summary>
        public const string STKCOO = "STKCOO";

        /// <summary>
        /// STDCTO.
        /// </summary>
        public const string STDCTO = "STDCTO";

        /// <summary>
        /// STLNID.
        /// </summary>
        public const string STLNID = "STLNID";

        /// <summary>
        /// STI75SRCT.
        /// </summary>
        public const string STI75SRCT = "STI75SRCT";

        /// <summary>
        /// STI75PSP.
        /// </summary>
        public const string STI75PSP = "STI75PSP";

        /// <summary>
        /// STI75PSR.
        /// </summary>
        public const string STI75PSR = "STI75PSR";

        /// <summary>
        /// STI75PST.
        /// </summary>
        public const string STI75PST = "STI75PST";

        /// <summary>
        /// STI75PEC.
        /// </summary>
        public const string STI75PEC = "STI75PEC";

        /// <summary>
        /// STI75PHC.
        /// </summary>
        public const string STI75PHC = "STI75PHC";

        /// <summary>
        /// STI75GL01.
        /// </summary>
        public const string STI75GL01 = "STI75GL01";

        /// <summary>
        /// STI75GL02.
        /// </summary>
        public const string STI75GL02 = "STI75GL02";

        /// <summary>
        /// STI75GL03.
        /// </summary>
        public const string STI75GL03 = "STI75GL03";

        /// <summary>
        /// STCRCD.
        /// </summary>
        public const string STCRCD = "STCRCD";

        /// <summary>
        /// STDOC.
        /// </summary>
        public const string STDOC = "STDOC";

        /// <summary>
        /// STDCT.
        /// </summary>
        public const string STDCT = "STDCT";

        /// <summary>
        /// STKCO.
        /// </summary>
        public const string STKCO = "STKCO";

        /// <summary>
        /// STAEXP.
        /// </summary>
        public const string STAEXP = "STAEXP";

        /// <summary>
        /// STI75SRAP.
        /// </summary>
        public const string STI75SRAP = "STI75SRAP";

        /// <summary>
        /// STI75ECAP.
        /// </summary>
        public const string STI75ECAP = "STI75ECAP";

        /// <summary>
        /// STI75HCAP.
        /// </summary>
        public const string STI75HCAP = "STI75HCAP";

        /// <summary>
        /// STI75SRAR.
        /// </summary>
        public const string STI75SRAR = "STI75SRAR";

        /// <summary>
        /// STI75ECAR.
        /// </summary>
        public const string STI75ECAR = "STI75ECAR";

        /// <summary>
        /// STI75HCAR.
        /// </summary>
        public const string STI75HCAR = "STI75HCAR";

        /// <summary>
        /// STI75SRMP.
        /// </summary>
        public const string STI75SRMP = "STI75SRMP";

        /// <summary>
        /// STI75ECMP.
        /// </summary>
        public const string STI75ECMP = "STI75ECMP";

        /// <summary>
        /// STI75HCMP.
        /// </summary>
        public const string STI75HCMP = "STI75HCMP";

        /// <summary>
        /// STI75SRMR.
        /// </summary>
        public const string STI75SRMR = "STI75SRMR";

        /// <summary>
        /// STI75ECMR.
        /// </summary>
        public const string STI75ECMR = "STI75ECMR";

        /// <summary>
        /// STI75HCMR.
        /// </summary>
        public const string STI75HCMR = "STI75HCMR";

        /// <summary>
        /// STI75PFLG.
        /// </summary>
        public const string STI75PFLG = "STI75PFLG";

        /// <summary>
        /// STUSER.
        /// </summary>
        public const string STUSER = "STUSER";

        /// <summary>
        /// STPID.
        /// </summary>
        public const string STPID = "STPID";

        /// <summary>
        /// STJOBN.
        /// </summary>
        public const string STJOBN = "STJOBN";

        /// <summary>
        /// STUPMJ.
        /// </summary>
        public const string STUPMJ = "STUPMJ";

        /// <summary>
        /// STUPMT.
        /// </summary>
        public const string STUPMT = "STUPMT";

        /// <summary>
        /// STURCD.
        /// </summary>
        public const string STURCD = "STURCD";

        /// <summary>
        /// STURDT.
        /// </summary>
        public const string STURDT = "STURDT";

        /// <summary>
        /// STURAT.
        /// </summary>
        public const string STURAT = "STURAT";

        /// <summary>
        /// STURAB.
        /// </summary>
        public const string STURAB = "STURAB";

        /// <summary>
        /// STURRF.
        /// </summary>
        public const string STURRF = "STURRF";

        /// <summary>
        /// STI75PSBC.
        /// </summary>
        public const string STI75PSBC = "STI75PSBC";

        /// <summary>
        /// STI75GL04.
        /// </summary>
        public const string STI75GL04 = "STI75GL04";

        /// <summary>
        /// STI75SBCAP.
        /// </summary>
        public const string STI75SBCAP = "STI75SBCAP";

        /// <summary>
        /// STI75SBCAR.
        /// </summary>
        public const string STI75SBCAR = "STI75SBCAR";

        /// <summary>
        /// STI75SBCMR.
        /// </summary>
        public const string STI75SBCMR = "STI75SBCMR";

        /// <summary>
        /// STI75SBCMP.
        /// </summary>
        public const string STI75SBCMP = "STI75SBCMP";

        /// <summary>
        /// STI75KKC.
        /// </summary>
        public const string STI75KKC = "STI75KKC";

        /// <summary>
        /// STI75GL05.
        /// </summary>
        public const string STI75GL05 = "STI75GL05";

        /// <summary>
        /// STI75KKCAP.
        /// </summary>
        public const string STI75KKCAP = "STI75KKCAP";

        /// <summary>
        /// STI75KKCAR.
        /// </summary>
        public const string STI75KKCAR = "STI75KKCAR";

        /// <summary>
        /// STI75KKCMP.
        /// </summary>
        public const string STI75KKCMP = "STI75KKCMP";

        /// <summary>
        /// STI75KKCMR.
        /// </summary>
        public const string STI75KKCMR = "STI75KKCMR";
    }

    /// <inheritdoc />
    public override string TableName => "F75I735";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("STDOCO", "STDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("STKCOO", "STKCOO", JdeDataType.String, 10, true, true),
        new JdeField("STDCTO", "STDCTO", JdeDataType.String, 4, true, true),
        new JdeField("STLNID", "STLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("STI75SRCT", "STI75SRCT", JdeDataType.String, 12),
        new JdeField("STI75PSP", "STI75PSP", JdeDataType.Numeric),
        new JdeField("STI75PSR", "STI75PSR", JdeDataType.Numeric),
        new JdeField("STI75PST", "STI75PST", JdeDataType.Numeric),
        new JdeField("STI75PEC", "STI75PEC", JdeDataType.Numeric),
        new JdeField("STI75PHC", "STI75PHC", JdeDataType.Numeric),
        new JdeField("STI75GL01", "STI75GL01", JdeDataType.String, 8),
        new JdeField("STI75GL02", "STI75GL02", JdeDataType.String, 8),
        new JdeField("STI75GL03", "STI75GL03", JdeDataType.String, 8),
        new JdeField("STCRCD", "STCRCD", JdeDataType.String, 6),
        new JdeField("STDOC", "STDOC", JdeDataType.Numeric),
        new JdeField("STDCT", "STDCT", JdeDataType.String, 4),
        new JdeField("STKCO", "STKCO", JdeDataType.String, 10),
        new JdeField("STAEXP", "STAEXP", JdeDataType.Numeric),
        new JdeField("STI75SRAP", "STI75SRAP", JdeDataType.Numeric),
        new JdeField("STI75ECAP", "STI75ECAP", JdeDataType.Numeric),
        new JdeField("STI75HCAP", "STI75HCAP", JdeDataType.Numeric),
        new JdeField("STI75SRAR", "STI75SRAR", JdeDataType.Numeric),
        new JdeField("STI75ECAR", "STI75ECAR", JdeDataType.Numeric),
        new JdeField("STI75HCAR", "STI75HCAR", JdeDataType.Numeric),
        new JdeField("STI75SRMP", "STI75SRMP", JdeDataType.Numeric),
        new JdeField("STI75ECMP", "STI75ECMP", JdeDataType.Numeric),
        new JdeField("STI75HCMP", "STI75HCMP", JdeDataType.Numeric),
        new JdeField("STI75SRMR", "STI75SRMR", JdeDataType.Numeric),
        new JdeField("STI75ECMR", "STI75ECMR", JdeDataType.Numeric),
        new JdeField("STI75HCMR", "STI75HCMR", JdeDataType.Numeric),
        new JdeField("STI75PFLG", "STI75PFLG", JdeDataType.String, 2),
        new JdeField("STUSER", "STUSER", JdeDataType.String, 20),
        new JdeField("STPID", "STPID", JdeDataType.String, 20),
        new JdeField("STJOBN", "STJOBN", JdeDataType.String, 20),
        new JdeField("STUPMJ", "STUPMJ", JdeDataType.Numeric),
        new JdeField("STUPMT", "STUPMT", JdeDataType.Numeric),
        new JdeField("STURCD", "STURCD", JdeDataType.String, 4),
        new JdeField("STURDT", "STURDT", JdeDataType.Numeric),
        new JdeField("STURAT", "STURAT", JdeDataType.Numeric),
        new JdeField("STURAB", "STURAB", JdeDataType.Numeric),
        new JdeField("STURRF", "STURRF", JdeDataType.String, 30),
        new JdeField("STI75PSBC", "STI75PSBC", JdeDataType.Numeric),
        new JdeField("STI75GL04", "STI75GL04", JdeDataType.String, 8),
        new JdeField("STI75SBCAP", "STI75SBCAP", JdeDataType.Numeric),
        new JdeField("STI75SBCAR", "STI75SBCAR", JdeDataType.Numeric),
        new JdeField("STI75SBCMR", "STI75SBCMR", JdeDataType.Numeric),
        new JdeField("STI75SBCMP", "STI75SBCMP", JdeDataType.Numeric),
        new JdeField("STI75KKC", "STI75KKC", JdeDataType.Numeric),
        new JdeField("STI75GL05", "STI75GL05", JdeDataType.String, 8),
        new JdeField("STI75KKCAP", "STI75KKCAP", JdeDataType.Numeric),
        new JdeField("STI75KKCAR", "STI75KKCAR", JdeDataType.Numeric),
        new JdeField("STI75KKCMP", "STI75KKCMP", JdeDataType.Numeric),
        new JdeField("STI75KKCMR", "STI75KKCMR", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75I735_0", "Primary Key on STDOCO, STKCOO, STDCTO, STLNID", new[] { "STDOCO", "STKCOO", "STDCTO", "STLNID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F75I735_2", "Index on STDOC, STDCT, STKCO", new[] { "STDOC", "STDCT", "STKCO" })
    };
}
