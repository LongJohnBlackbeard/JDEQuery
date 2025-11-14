using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F46098 - .
/// </summary>
public class F46098 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CBMCU.
        /// </summary>
        public const string CBMCU = "CBMCU";

        /// <summary>
        /// CBEQTY.
        /// </summary>
        public const string CBEQTY = "CBEQTY";

        /// <summary>
        /// CBCNPC.
        /// </summary>
        public const string CBCNPC = "CBCNPC";

        /// <summary>
        /// CBQNTY.
        /// </summary>
        public const string CBQNTY = "CBQNTY";

        /// <summary>
        /// CBITM.
        /// </summary>
        public const string CBITM = "CBITM";

        /// <summary>
        /// CBC1FU.
        /// </summary>
        public const string CBC1FU = "CBC1FU";

        /// <summary>
        /// CBCFC1.
        /// </summary>
        public const string CBCFC1 = "CBCFC1";

        /// <summary>
        /// CBCFS1.
        /// </summary>
        public const string CBCFS1 = "CBCFS1";

        /// <summary>
        /// CBD1FU.
        /// </summary>
        public const string CBD1FU = "CBD1FU";

        /// <summary>
        /// CBURCD.
        /// </summary>
        public const string CBURCD = "CBURCD";

        /// <summary>
        /// CBURDT.
        /// </summary>
        public const string CBURDT = "CBURDT";

        /// <summary>
        /// CBURAT.
        /// </summary>
        public const string CBURAT = "CBURAT";

        /// <summary>
        /// CBURAB.
        /// </summary>
        public const string CBURAB = "CBURAB";

        /// <summary>
        /// CBURRF.
        /// </summary>
        public const string CBURRF = "CBURRF";

        /// <summary>
        /// CBUSER.
        /// </summary>
        public const string CBUSER = "CBUSER";

        /// <summary>
        /// CBPID.
        /// </summary>
        public const string CBPID = "CBPID";

        /// <summary>
        /// CBJOBN.
        /// </summary>
        public const string CBJOBN = "CBJOBN";

        /// <summary>
        /// CBUPMJ.
        /// </summary>
        public const string CBUPMJ = "CBUPMJ";

        /// <summary>
        /// CBTDAY.
        /// </summary>
        public const string CBTDAY = "CBTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F46098";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CBMCU", "CBMCU", JdeDataType.String, 24, true, true),
        new JdeField("CBEQTY", "CBEQTY", JdeDataType.String, 10, true, true),
        new JdeField("CBCNPC", "CBCNPC", JdeDataType.String, 10, true, true),
        new JdeField("CBQNTY", "CBQNTY", JdeDataType.Numeric),
        new JdeField("CBITM", "CBITM", JdeDataType.Numeric),
        new JdeField("CBC1FU", "CBC1FU", JdeDataType.String, 2),
        new JdeField("CBCFC1", "CBCFC1", JdeDataType.String, 6),
        new JdeField("CBCFS1", "CBCFS1", JdeDataType.Numeric),
        new JdeField("CBD1FU", "CBD1FU", JdeDataType.Numeric),
        new JdeField("CBURCD", "CBURCD", JdeDataType.String, 4),
        new JdeField("CBURDT", "CBURDT", JdeDataType.Numeric),
        new JdeField("CBURAT", "CBURAT", JdeDataType.Numeric),
        new JdeField("CBURAB", "CBURAB", JdeDataType.Numeric),
        new JdeField("CBURRF", "CBURRF", JdeDataType.String, 30),
        new JdeField("CBUSER", "CBUSER", JdeDataType.String, 20),
        new JdeField("CBPID", "CBPID", JdeDataType.String, 20),
        new JdeField("CBJOBN", "CBJOBN", JdeDataType.String, 20),
        new JdeField("CBUPMJ", "CBUPMJ", JdeDataType.Numeric),
        new JdeField("CBTDAY", "CBTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F46098_0", "Primary Key on CBMCU, CBEQTY, CBCNPC", new[] { "CBMCU", "CBEQTY", "CBCNPC" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F46098_2", "Index on CBMCU, CBEQTY", new[] { "CBMCU", "CBEQTY" }),
        new JdeIndex("F46098_3", "Index on CBMCU, CBCNPC", new[] { "CBMCU", "CBCNPC" })
    };
}
