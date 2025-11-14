using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75T0029 - .
/// </summary>
public class F75T0029 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// NR75TUIP.
        /// </summary>
        public const string NR75TUIP = "NR75TUIP";

        /// <summary>
        /// NR75TGRF.
        /// </summary>
        public const string NR75TGRF = "NR75TGRF";

        /// <summary>
        /// NR75TGRT.
        /// </summary>
        public const string NR75TGRT = "NR75TGRT";

        /// <summary>
        /// NR75TSNN.
        /// </summary>
        public const string NR75TSNN = "NR75TSNN";

        /// <summary>
        /// NR75TGFC.
        /// </summary>
        public const string NR75TGFC = "NR75TGFC";

        /// <summary>
        /// NR75TGRA.
        /// </summary>
        public const string NR75TGRA = "NR75TGRA";

        /// <summary>
        /// NREFFF.
        /// </summary>
        public const string NREFFF = "NREFFF";

        /// <summary>
        /// NREFFT.
        /// </summary>
        public const string NREFFT = "NREFFT";

        /// <summary>
        /// NRCO.
        /// </summary>
        public const string NRCO = "NRCO";

        /// <summary>
        /// NR75TDSI.
        /// </summary>
        public const string NR75TDSI = "NR75TDSI";

        /// <summary>
        /// NR75TYMD.
        /// </summary>
        public const string NR75TYMD = "NR75TYMD";

        /// <summary>
        /// NR75TYMH.
        /// </summary>
        public const string NR75TYMH = "NR75TYMH";

        /// <summary>
        /// NR75TDCT.
        /// </summary>
        public const string NR75TDCT = "NR75TDCT";

        /// <summary>
        /// NRURC1.
        /// </summary>
        public const string NRURC1 = "NRURC1";

        /// <summary>
        /// NRURDT.
        /// </summary>
        public const string NRURDT = "NRURDT";

        /// <summary>
        /// NRURAT.
        /// </summary>
        public const string NRURAT = "NRURAT";

        /// <summary>
        /// NRURAB.
        /// </summary>
        public const string NRURAB = "NRURAB";

        /// <summary>
        /// NRURRF.
        /// </summary>
        public const string NRURRF = "NRURRF";

        /// <summary>
        /// NRUSER.
        /// </summary>
        public const string NRUSER = "NRUSER";

        /// <summary>
        /// NRPID.
        /// </summary>
        public const string NRPID = "NRPID";

        /// <summary>
        /// NRJOBN.
        /// </summary>
        public const string NRJOBN = "NRJOBN";

        /// <summary>
        /// NRUPMJ.
        /// </summary>
        public const string NRUPMJ = "NRUPMJ";

        /// <summary>
        /// NRTDAY.
        /// </summary>
        public const string NRTDAY = "NRTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F75T0029";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("NR75TUIP", "NR75TUIP", JdeDataType.String, 4, true, true),
        new JdeField("NR75TGRF", "NR75TGRF", JdeDataType.Numeric, null, true, true),
        new JdeField("NR75TGRT", "NR75TGRT", JdeDataType.Numeric),
        new JdeField("NR75TSNN", "NR75TSNN", JdeDataType.Numeric),
        new JdeField("NR75TGFC", "NR75TGFC", JdeDataType.String, 4),
        new JdeField("NR75TGRA", "NR75TGRA", JdeDataType.String, 2),
        new JdeField("NREFFF", "NREFFF", JdeDataType.Numeric),
        new JdeField("NREFFT", "NREFFT", JdeDataType.Numeric),
        new JdeField("NRCO", "NRCO", JdeDataType.String, 10),
        new JdeField("NR75TDSI", "NR75TDSI", JdeDataType.String, 10),
        new JdeField("NR75TYMD", "NR75TYMD", JdeDataType.Numeric),
        new JdeField("NR75TYMH", "NR75TYMH", JdeDataType.Numeric),
        new JdeField("NR75TDCT", "NR75TDCT", JdeDataType.String, 6),
        new JdeField("NRURC1", "NRURC1", JdeDataType.String, 6),
        new JdeField("NRURDT", "NRURDT", JdeDataType.Numeric),
        new JdeField("NRURAT", "NRURAT", JdeDataType.Numeric),
        new JdeField("NRURAB", "NRURAB", JdeDataType.Numeric),
        new JdeField("NRURRF", "NRURRF", JdeDataType.String, 30),
        new JdeField("NRUSER", "NRUSER", JdeDataType.String, 20),
        new JdeField("NRPID", "NRPID", JdeDataType.String, 20),
        new JdeField("NRJOBN", "NRJOBN", JdeDataType.String, 20),
        new JdeField("NRUPMJ", "NRUPMJ", JdeDataType.Numeric),
        new JdeField("NRTDAY", "NRTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75T0029_0", "Primary Key on NR75TUIP, NR75TGRF", new[] { "NR75TUIP", "NR75TGRF" }, isUnique: true, isPrimaryKey: true)
    };
}
