using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75T0039 - .
/// </summary>
public class F75T0039 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// NS75TUIP.
        /// </summary>
        public const string NS75TUIP = "NS75TUIP";

        /// <summary>
        /// NS75TGRF.
        /// </summary>
        public const string NS75TGRF = "NS75TGRF";

        /// <summary>
        /// NS75TGSF.
        /// </summary>
        public const string NS75TGSF = "NS75TGSF";

        /// <summary>
        /// NS75TGST.
        /// </summary>
        public const string NS75TGST = "NS75TGST";

        /// <summary>
        /// NS75TAUC.
        /// </summary>
        public const string NS75TAUC = "NS75TAUC";

        /// <summary>
        /// NS75TGNN.
        /// </summary>
        public const string NS75TGNN = "NS75TGNN";

        /// <summary>
        /// NS75TGUC.
        /// </summary>
        public const string NS75TGUC = "NS75TGUC";

        /// <summary>
        /// NSDQU.
        /// </summary>
        public const string NSDQU = "NSDQU";

        /// <summary>
        /// NS75TGSA.
        /// </summary>
        public const string NS75TGSA = "NS75TGSA";

        /// <summary>
        /// NSEFFF.
        /// </summary>
        public const string NSEFFF = "NSEFFF";

        /// <summary>
        /// NSEFFT.
        /// </summary>
        public const string NSEFFT = "NSEFFT";

        /// <summary>
        /// NSCO.
        /// </summary>
        public const string NSCO = "NSCO";

        /// <summary>
        /// NS75TDSI.
        /// </summary>
        public const string NS75TDSI = "NS75TDSI";

        /// <summary>
        /// NS75TDCT.
        /// </summary>
        public const string NS75TDCT = "NS75TDCT";

        /// <summary>
        /// NS75TRVT.
        /// </summary>
        public const string NS75TRVT = "NS75TRVT";

        /// <summary>
        /// NS75TCC1.
        /// </summary>
        public const string NS75TCC1 = "NS75TCC1";

        /// <summary>
        /// NS75TCC2.
        /// </summary>
        public const string NS75TCC2 = "NS75TCC2";

        /// <summary>
        /// NS75TCC3.
        /// </summary>
        public const string NS75TCC3 = "NS75TCC3";

        /// <summary>
        /// NSURC1.
        /// </summary>
        public const string NSURC1 = "NSURC1";

        /// <summary>
        /// NSURDT.
        /// </summary>
        public const string NSURDT = "NSURDT";

        /// <summary>
        /// NSURAT.
        /// </summary>
        public const string NSURAT = "NSURAT";

        /// <summary>
        /// NSURAB.
        /// </summary>
        public const string NSURAB = "NSURAB";

        /// <summary>
        /// NSURRF.
        /// </summary>
        public const string NSURRF = "NSURRF";

        /// <summary>
        /// NSUSER.
        /// </summary>
        public const string NSUSER = "NSUSER";

        /// <summary>
        /// NSPID.
        /// </summary>
        public const string NSPID = "NSPID";

        /// <summary>
        /// NSJOBN.
        /// </summary>
        public const string NSJOBN = "NSJOBN";

        /// <summary>
        /// NSUPMJ.
        /// </summary>
        public const string NSUPMJ = "NSUPMJ";

        /// <summary>
        /// NSTDAY.
        /// </summary>
        public const string NSTDAY = "NSTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F75T0039";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("NS75TUIP", "NS75TUIP", JdeDataType.String, 4, true, true),
        new JdeField("NS75TGRF", "NS75TGRF", JdeDataType.Numeric, null, true, true),
        new JdeField("NS75TGSF", "NS75TGSF", JdeDataType.Numeric, null, true, true),
        new JdeField("NS75TGST", "NS75TGST", JdeDataType.Numeric),
        new JdeField("NS75TAUC", "NS75TAUC", JdeDataType.String, 20),
        new JdeField("NS75TGNN", "NS75TGNN", JdeDataType.Numeric),
        new JdeField("NS75TGUC", "NS75TGUC", JdeDataType.Numeric),
        new JdeField("NSDQU", "NSDQU", JdeDataType.Numeric),
        new JdeField("NS75TGSA", "NS75TGSA", JdeDataType.String, 2),
        new JdeField("NSEFFF", "NSEFFF", JdeDataType.Numeric),
        new JdeField("NSEFFT", "NSEFFT", JdeDataType.Numeric),
        new JdeField("NSCO", "NSCO", JdeDataType.String, 10),
        new JdeField("NS75TDSI", "NS75TDSI", JdeDataType.String, 10),
        new JdeField("NS75TDCT", "NS75TDCT", JdeDataType.String, 6),
        new JdeField("NS75TRVT", "NS75TRVT", JdeDataType.String, 6),
        new JdeField("NS75TCC1", "NS75TCC1", JdeDataType.String, 6),
        new JdeField("NS75TCC2", "NS75TCC2", JdeDataType.String, 6),
        new JdeField("NS75TCC3", "NS75TCC3", JdeDataType.String, 6),
        new JdeField("NSURC1", "NSURC1", JdeDataType.String, 6),
        new JdeField("NSURDT", "NSURDT", JdeDataType.Numeric),
        new JdeField("NSURAT", "NSURAT", JdeDataType.Numeric),
        new JdeField("NSURAB", "NSURAB", JdeDataType.Numeric),
        new JdeField("NSURRF", "NSURRF", JdeDataType.String, 30),
        new JdeField("NSUSER", "NSUSER", JdeDataType.String, 20),
        new JdeField("NSPID", "NSPID", JdeDataType.String, 20),
        new JdeField("NSJOBN", "NSJOBN", JdeDataType.String, 20),
        new JdeField("NSUPMJ", "NSUPMJ", JdeDataType.Numeric),
        new JdeField("NSTDAY", "NSTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75T0039_0", "Primary Key on NS75TUIP, NS75TGRF, NS75TGSF", new[] { "NS75TUIP", "NS75TGRF", "NS75TGSF" }, isUnique: true, isPrimaryKey: true)
    };
}
