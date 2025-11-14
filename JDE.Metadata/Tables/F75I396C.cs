using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75I396C - .
/// </summary>
public class F75I396C : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// OBLITM.
        /// </summary>
        public const string OBLITM = "OBLITM";

        /// <summary>
        /// OBITM.
        /// </summary>
        public const string OBITM = "OBITM";

        /// <summary>
        /// OBTRQT.
        /// </summary>
        public const string OBTRQT = "OBTRQT";

        /// <summary>
        /// OBUPMT.
        /// </summary>
        public const string OBUPMT = "OBUPMT";

        /// <summary>
        /// OBUPMJ.
        /// </summary>
        public const string OBUPMJ = "OBUPMJ";

        /// <summary>
        /// OBUSER.
        /// </summary>
        public const string OBUSER = "OBUSER";

        /// <summary>
        /// OBJOBN.
        /// </summary>
        public const string OBJOBN = "OBJOBN";

        /// <summary>
        /// OBPID.
        /// </summary>
        public const string OBPID = "OBPID";

        /// <summary>
        /// OBDTEN.
        /// </summary>
        public const string OBDTEN = "OBDTEN";

        /// <summary>
        /// OBYFUTDT1.
        /// </summary>
        public const string OBYFUTDT1 = "OBYFUTDT1";

        /// <summary>
        /// OBYFUTDT2.
        /// </summary>
        public const string OBYFUTDT2 = "OBYFUTDT2";

        /// <summary>
        /// OBYFUTDT3.
        /// </summary>
        public const string OBYFUTDT3 = "OBYFUTDT3";

        /// <summary>
        /// OBYFUTDT4.
        /// </summary>
        public const string OBYFUTDT4 = "OBYFUTDT4";

        /// <summary>
        /// OBYFUTDT5.
        /// </summary>
        public const string OBYFUTDT5 = "OBYFUTDT5";

        /// <summary>
        /// OBYFUSTR1.
        /// </summary>
        public const string OBYFUSTR1 = "OBYFUSTR1";

        /// <summary>
        /// OBYFUSTR2.
        /// </summary>
        public const string OBYFUSTR2 = "OBYFUSTR2";

        /// <summary>
        /// OBYFUSTR3.
        /// </summary>
        public const string OBYFUSTR3 = "OBYFUSTR3";

        /// <summary>
        /// OBYFUSTR4.
        /// </summary>
        public const string OBYFUSTR4 = "OBYFUSTR4";

        /// <summary>
        /// OBYFUSTR5.
        /// </summary>
        public const string OBYFUSTR5 = "OBYFUSTR5";

        /// <summary>
        /// OBYT01.
        /// </summary>
        public const string OBYT01 = "OBYT01";

        /// <summary>
        /// OBYT02.
        /// </summary>
        public const string OBYT02 = "OBYT02";

        /// <summary>
        /// OBYT03.
        /// </summary>
        public const string OBYT03 = "OBYT03";

        /// <summary>
        /// OBYT04.
        /// </summary>
        public const string OBYT04 = "OBYT04";

        /// <summary>
        /// OBYT05.
        /// </summary>
        public const string OBYT05 = "OBYT05";

        /// <summary>
        /// OBFUAM.
        /// </summary>
        public const string OBFUAM = "OBFUAM";

        /// <summary>
        /// OBYFUQTY2.
        /// </summary>
        public const string OBYFUQTY2 = "OBYFUQTY2";

        /// <summary>
        /// OBYFUQTY3.
        /// </summary>
        public const string OBYFUQTY3 = "OBYFUQTY3";

        /// <summary>
        /// OBMATH01.
        /// </summary>
        public const string OBMATH01 = "OBMATH01";

        /// <summary>
        /// OBMATH02.
        /// </summary>
        public const string OBMATH02 = "OBMATH02";

        /// <summary>
        /// OBMATH03.
        /// </summary>
        public const string OBMATH03 = "OBMATH03";

        /// <summary>
        /// OBMATH05.
        /// </summary>
        public const string OBMATH05 = "OBMATH05";
    }

    /// <inheritdoc />
    public override string TableName => "F75I396C";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("OBLITM", "OBLITM", JdeDataType.String, 50),
        new JdeField("OBITM", "OBITM", JdeDataType.Numeric, null, true, true),
        new JdeField("OBTRQT", "OBTRQT", JdeDataType.Numeric),
        new JdeField("OBUPMT", "OBUPMT", JdeDataType.Numeric),
        new JdeField("OBUPMJ", "OBUPMJ", JdeDataType.Numeric),
        new JdeField("OBUSER", "OBUSER", JdeDataType.String, 20),
        new JdeField("OBJOBN", "OBJOBN", JdeDataType.String, 20),
        new JdeField("OBPID", "OBPID", JdeDataType.String, 20),
        new JdeField("OBDTEN", "OBDTEN", JdeDataType.Numeric),
        new JdeField("OBYFUTDT1", "OBYFUTDT1", JdeDataType.Numeric),
        new JdeField("OBYFUTDT2", "OBYFUTDT2", JdeDataType.Numeric),
        new JdeField("OBYFUTDT3", "OBYFUTDT3", JdeDataType.Numeric),
        new JdeField("OBYFUTDT4", "OBYFUTDT4", JdeDataType.Numeric),
        new JdeField("OBYFUTDT5", "OBYFUTDT5", JdeDataType.Numeric),
        new JdeField("OBYFUSTR1", "OBYFUSTR1", JdeDataType.String, 60),
        new JdeField("OBYFUSTR2", "OBYFUSTR2", JdeDataType.String, 60),
        new JdeField("OBYFUSTR3", "OBYFUSTR3", JdeDataType.String, 60),
        new JdeField("OBYFUSTR4", "OBYFUSTR4", JdeDataType.String, 60),
        new JdeField("OBYFUSTR5", "OBYFUSTR5", JdeDataType.String, 60),
        new JdeField("OBYT01", "OBYT01", JdeDataType.String, 2),
        new JdeField("OBYT02", "OBYT02", JdeDataType.String, 2),
        new JdeField("OBYT03", "OBYT03", JdeDataType.String, 2),
        new JdeField("OBYT04", "OBYT04", JdeDataType.String, 2),
        new JdeField("OBYT05", "OBYT05", JdeDataType.String, 2),
        new JdeField("OBFUAM", "OBFUAM", JdeDataType.Numeric),
        new JdeField("OBYFUQTY2", "OBYFUQTY2", JdeDataType.Numeric),
        new JdeField("OBYFUQTY3", "OBYFUQTY3", JdeDataType.Numeric),
        new JdeField("OBMATH01", "OBMATH01", JdeDataType.Numeric),
        new JdeField("OBMATH02", "OBMATH02", JdeDataType.Numeric),
        new JdeField("OBMATH03", "OBMATH03", JdeDataType.Numeric),
        new JdeField("OBMATH05", "OBMATH05", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75I396C_0", "Primary Key on OBITM", new[] { "OBITM" }, isUnique: true, isPrimaryKey: true)
    };
}
