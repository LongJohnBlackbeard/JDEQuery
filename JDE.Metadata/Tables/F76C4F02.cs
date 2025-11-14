using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76C4F02 - .
/// </summary>
public class F76C4F02 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// FIC76FMT.
        /// </summary>
        public const string FIC76FMT = "FIC76FMT";

        /// <summary>
        /// FIKCO.
        /// </summary>
        public const string FIKCO = "FIKCO";

        /// <summary>
        /// FIDCT.
        /// </summary>
        public const string FIDCT = "FIDCT";

        /// <summary>
        /// FIDOC.
        /// </summary>
        public const string FIDOC = "FIDOC";

        /// <summary>
        /// FISFX.
        /// </summary>
        public const string FISFX = "FISFX";

        /// <summary>
        /// FISFXE.
        /// </summary>
        public const string FISFXE = "FISFXE";

        /// <summary>
        /// FIC76CEPT.
        /// </summary>
        public const string FIC76CEPT = "FIC76CEPT";

        /// <summary>
        /// FIC76STS.
        /// </summary>
        public const string FIC76STS = "FIC76STS";

        /// <summary>
        /// FIAN8.
        /// </summary>
        public const string FIAN8 = "FIAN8";

        /// <summary>
        /// FI76CTAX.
        /// </summary>
        public const string FI76CTAX = "FI76CTAX";

        /// <summary>
        /// FIC76TAXA.
        /// </summary>
        public const string FIC76TAXA = "FIC76TAXA";

        /// <summary>
        /// FIC76DDCT.
        /// </summary>
        public const string FIC76DDCT = "FIC76DDCT";

        /// <summary>
        /// FIAA1.
        /// </summary>
        public const string FIAA1 = "FIAA1";

        /// <summary>
        /// FIAA2.
        /// </summary>
        public const string FIAA2 = "FIAA2";

        /// <summary>
        /// FISEQ.
        /// </summary>
        public const string FISEQ = "FISEQ";

        /// <summary>
        /// FIUSER.
        /// </summary>
        public const string FIUSER = "FIUSER";

        /// <summary>
        /// FIPID.
        /// </summary>
        public const string FIPID = "FIPID";

        /// <summary>
        /// FIVERS.
        /// </summary>
        public const string FIVERS = "FIVERS";

        /// <summary>
        /// FIJOBN.
        /// </summary>
        public const string FIJOBN = "FIJOBN";

        /// <summary>
        /// FIUPMT.
        /// </summary>
        public const string FIUPMT = "FIUPMT";

        /// <summary>
        /// FIUPMJ.
        /// </summary>
        public const string FIUPMJ = "FIUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "F76C4F02";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("FIC76FMT", "FIC76FMT", JdeDataType.String, 10, true, true),
        new JdeField("FIKCO", "FIKCO", JdeDataType.String, 10, true, true),
        new JdeField("FIDCT", "FIDCT", JdeDataType.String, 4, true, true),
        new JdeField("FIDOC", "FIDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("FISFX", "FISFX", JdeDataType.String, 6, true, true),
        new JdeField("FISFXE", "FISFXE", JdeDataType.Numeric, null, true, true),
        new JdeField("FIC76CEPT", "FIC76CEPT", JdeDataType.String, 8),
        new JdeField("FIC76STS", "FIC76STS", JdeDataType.String, 2),
        new JdeField("FIAN8", "FIAN8", JdeDataType.Numeric),
        new JdeField("FI76CTAX", "FI76CTAX", JdeDataType.String, 40),
        new JdeField("FIC76TAXA", "FIC76TAXA", JdeDataType.String, 40),
        new JdeField("FIC76DDCT", "FIC76DDCT", JdeDataType.Numeric),
        new JdeField("FIAA1", "FIAA1", JdeDataType.Numeric),
        new JdeField("FIAA2", "FIAA2", JdeDataType.Numeric),
        new JdeField("FISEQ", "FISEQ", JdeDataType.Numeric),
        new JdeField("FIUSER", "FIUSER", JdeDataType.String, 20),
        new JdeField("FIPID", "FIPID", JdeDataType.String, 20),
        new JdeField("FIVERS", "FIVERS", JdeDataType.String, 20),
        new JdeField("FIJOBN", "FIJOBN", JdeDataType.String, 20),
        new JdeField("FIUPMT", "FIUPMT", JdeDataType.Numeric),
        new JdeField("FIUPMJ", "FIUPMJ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76C4F02_0", "Primary Key on FIC76FMT, FIKCO, FIDCT, FIDOC, FISFX, FISFXE", new[] { "FIC76FMT", "FIKCO", "FIDCT", "FIDOC", "FISFX", "FISFXE" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F76C4F02_2", "Index on FISEQ", new[] { "FISEQ" }),
        new JdeIndex("F76C4F02_3", "Index on FIC76CEPT, FIC76FMT, FI76CTAX", new[] { "FIC76CEPT", "FIC76FMT", "FI76CTAX" })
    };
}
