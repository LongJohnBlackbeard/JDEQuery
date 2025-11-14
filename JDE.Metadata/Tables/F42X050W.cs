using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F42X050W - .
/// </summary>
public class F42X050W : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CISNKY.
        /// </summary>
        public const string CISNKY = "CISNKY";

        /// <summary>
        /// CILNIX.
        /// </summary>
        public const string CILNIX = "CILNIX";

        /// <summary>
        /// CIPRGR.
        /// </summary>
        public const string CIPRGR = "CIPRGR";

        /// <summary>
        /// CIOLVL.
        /// </summary>
        public const string CIOLVL = "CIOLVL";

        /// <summary>
        /// CIITM.
        /// </summary>
        public const string CIITM = "CIITM";

        /// <summary>
        /// CIMCU.
        /// </summary>
        public const string CIMCU = "CIMCU";

        /// <summary>
        /// CIUORG.
        /// </summary>
        public const string CIUORG = "CIUORG";

        /// <summary>
        /// CIUOM.
        /// </summary>
        public const string CIUOM = "CIUOM";

        /// <summary>
        /// CICUMQTY.
        /// </summary>
        public const string CICUMQTY = "CICUMQTY";

        /// <summary>
        /// CIUOM2.
        /// </summary>
        public const string CIUOM2 = "CIUOM2";

        /// <summary>
        /// CIUOM4.
        /// </summary>
        public const string CIUOM4 = "CIUOM4";

        /// <summary>
        /// CIITWT.
        /// </summary>
        public const string CIITWT = "CIITWT";

        /// <summary>
        /// CICUMWGT.
        /// </summary>
        public const string CICUMWGT = "CICUMWGT";

        /// <summary>
        /// CIWTUM.
        /// </summary>
        public const string CIWTUM = "CIWTUM";

        /// <summary>
        /// CIUPRC.
        /// </summary>
        public const string CIUPRC = "CIUPRC";

        /// <summary>
        /// CIAEXP.
        /// </summary>
        public const string CIAEXP = "CIAEXP";

        /// <summary>
        /// CIFUP.
        /// </summary>
        public const string CIFUP = "CIFUP";

        /// <summary>
        /// CIFEA.
        /// </summary>
        public const string CIFEA = "CIFEA";

        /// <summary>
        /// CITUPRC.
        /// </summary>
        public const string CITUPRC = "CITUPRC";

        /// <summary>
        /// CITAEXP.
        /// </summary>
        public const string CITAEXP = "CITAEXP";

        /// <summary>
        /// CITFUP.
        /// </summary>
        public const string CITFUP = "CITFUP";

        /// <summary>
        /// CITFEA.
        /// </summary>
        public const string CITFEA = "CITFEA";

        /// <summary>
        /// CI42XCONV.
        /// </summary>
        public const string CI42XCONV = "CI42XCONV";

        /// <summary>
        /// CI42XCANC.
        /// </summary>
        public const string CI42XCANC = "CI42XCANC";

        /// <summary>
        /// CI42XRGIT.
        /// </summary>
        public const string CI42XRGIT = "CI42XRGIT";

        /// <summary>
        /// CIKCOO.
        /// </summary>
        public const string CIKCOO = "CIKCOO";

        /// <summary>
        /// CICRCD.
        /// </summary>
        public const string CICRCD = "CICRCD";

        /// <summary>
        /// CISTKT.
        /// </summary>
        public const string CISTKT = "CISTKT";

        /// <summary>
        /// CIUSER.
        /// </summary>
        public const string CIUSER = "CIUSER";

        /// <summary>
        /// CIPID.
        /// </summary>
        public const string CIPID = "CIPID";

        /// <summary>
        /// CIJOBN.
        /// </summary>
        public const string CIJOBN = "CIJOBN";

        /// <summary>
        /// CIUPMJ.
        /// </summary>
        public const string CIUPMJ = "CIUPMJ";

        /// <summary>
        /// CIUPMT.
        /// </summary>
        public const string CIUPMT = "CIUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F42X050W";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CISNKY", "CISNKY", JdeDataType.String, 64, true, true),
        new JdeField("CILNIX", "CILNIX", JdeDataType.Numeric, null, true, true),
        new JdeField("CIPRGR", "CIPRGR", JdeDataType.String, 16, true, true),
        new JdeField("CIOLVL", "CIOLVL", JdeDataType.String, 2, true, true),
        new JdeField("CIITM", "CIITM", JdeDataType.Numeric, null, true, true),
        new JdeField("CIMCU", "CIMCU", JdeDataType.String, 24, true, true),
        new JdeField("CIUORG", "CIUORG", JdeDataType.Numeric),
        new JdeField("CIUOM", "CIUOM", JdeDataType.String, 4),
        new JdeField("CICUMQTY", "CICUMQTY", JdeDataType.Numeric),
        new JdeField("CIUOM2", "CIUOM2", JdeDataType.String, 4),
        new JdeField("CIUOM4", "CIUOM4", JdeDataType.String, 4),
        new JdeField("CIITWT", "CIITWT", JdeDataType.Numeric),
        new JdeField("CICUMWGT", "CICUMWGT", JdeDataType.Numeric),
        new JdeField("CIWTUM", "CIWTUM", JdeDataType.String, 4),
        new JdeField("CIUPRC", "CIUPRC", JdeDataType.Numeric),
        new JdeField("CIAEXP", "CIAEXP", JdeDataType.Numeric),
        new JdeField("CIFUP", "CIFUP", JdeDataType.Numeric),
        new JdeField("CIFEA", "CIFEA", JdeDataType.Numeric),
        new JdeField("CITUPRC", "CITUPRC", JdeDataType.Numeric),
        new JdeField("CITAEXP", "CITAEXP", JdeDataType.Numeric),
        new JdeField("CITFUP", "CITFUP", JdeDataType.Numeric),
        new JdeField("CITFEA", "CITFEA", JdeDataType.Numeric),
        new JdeField("CI42XCONV", "CI42XCONV", JdeDataType.String, 2),
        new JdeField("CI42XCANC", "CI42XCANC", JdeDataType.String, 2),
        new JdeField("CI42XRGIT", "CI42XRGIT", JdeDataType.String, 2),
        new JdeField("CIKCOO", "CIKCOO", JdeDataType.String, 10),
        new JdeField("CICRCD", "CICRCD", JdeDataType.String, 6),
        new JdeField("CISTKT", "CISTKT", JdeDataType.String, 2),
        new JdeField("CIUSER", "CIUSER", JdeDataType.String, 20),
        new JdeField("CIPID", "CIPID", JdeDataType.String, 20),
        new JdeField("CIJOBN", "CIJOBN", JdeDataType.String, 20),
        new JdeField("CIUPMJ", "CIUPMJ", JdeDataType.Numeric),
        new JdeField("CIUPMT", "CIUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F42X050W_0", "Primary Key on CISNKY, CILNIX, CIPRGR, CIOLVL, CIITM, CIMCU", new[] { "CISNKY", "CILNIX", "CIPRGR", "CIOLVL", "CIITM", "CIMCU" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F42X050W_2", "Index on CISNKY", new[] { "CISNKY" }),
        new JdeIndex("F42X050W_3", "Index on CISNKY, CI42XRGIT, CILNIX, CIITM, CIMCU", new[] { "CISNKY", "CI42XRGIT", "CILNIX", "CIITM", "CIMCU" }),
        new JdeIndex("F42X050W_4", "Index on CISNKY, CIOLVL, CIPRGR, CIITM", new[] { "CISNKY", "CIOLVL", "CIPRGR", "CIITM" })
    };
}
