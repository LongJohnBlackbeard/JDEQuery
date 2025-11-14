using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F09J123 - .
/// </summary>
public class F09J123 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// JNUKID.
        /// </summary>
        public const string JNUKID = "JNUKID";

        /// <summary>
        /// JNJVSRCV.
        /// </summary>
        public const string JNJVSRCV = "JNJVSRCV";

        /// <summary>
        /// JNJVBASV.
        /// </summary>
        public const string JNJVBASV = "JNJVBASV";

        /// <summary>
        /// JNSRCBUSTS.
        /// </summary>
        public const string JNSRCBUSTS = "JNSRCBUSTS";

        /// <summary>
        /// JNBASBUSTS.
        /// </summary>
        public const string JNBASBUSTS = "JNBASBUSTS";

        /// <summary>
        /// JNSRCJVSTS.
        /// </summary>
        public const string JNSRCJVSTS = "JNSRCJVSTS";

        /// <summary>
        /// JNBASJVSTS.
        /// </summary>
        public const string JNBASJVSTS = "JNBASJVSTS";

        /// <summary>
        /// JNSRCINDT.
        /// </summary>
        public const string JNSRCINDT = "JNSRCINDT";

        /// <summary>
        /// JNBASINDT.
        /// </summary>
        public const string JNBASINDT = "JNBASINDT";

        /// <summary>
        /// JNURAB.
        /// </summary>
        public const string JNURAB = "JNURAB";

        /// <summary>
        /// JNURCD.
        /// </summary>
        public const string JNURCD = "JNURCD";

        /// <summary>
        /// JNURAT.
        /// </summary>
        public const string JNURAT = "JNURAT";

        /// <summary>
        /// JNURDT.
        /// </summary>
        public const string JNURDT = "JNURDT";

        /// <summary>
        /// JNURRF.
        /// </summary>
        public const string JNURRF = "JNURRF";

        /// <summary>
        /// JNJNTNU1.
        /// </summary>
        public const string JNJNTNU1 = "JNJNTNU1";

        /// <summary>
        /// JNJNTNU2.
        /// </summary>
        public const string JNJNTNU2 = "JNJNTNU2";

        /// <summary>
        /// JNJNTNU3.
        /// </summary>
        public const string JNJNTNU3 = "JNJNTNU3";

        /// <summary>
        /// JNJNTST1.
        /// </summary>
        public const string JNJNTST1 = "JNJNTST1";

        /// <summary>
        /// JNJNTST2.
        /// </summary>
        public const string JNJNTST2 = "JNJNTST2";

        /// <summary>
        /// JNJNTST3.
        /// </summary>
        public const string JNJNTST3 = "JNJNTST3";

        /// <summary>
        /// JNJNTCH1.
        /// </summary>
        public const string JNJNTCH1 = "JNJNTCH1";

        /// <summary>
        /// JNJNTCH2.
        /// </summary>
        public const string JNJNTCH2 = "JNJNTCH2";

        /// <summary>
        /// JNJNTCH3.
        /// </summary>
        public const string JNJNTCH3 = "JNJNTCH3";

        /// <summary>
        /// JNJNTDT1.
        /// </summary>
        public const string JNJNTDT1 = "JNJNTDT1";

        /// <summary>
        /// JNJNTDT2.
        /// </summary>
        public const string JNJNTDT2 = "JNJNTDT2";

        /// <summary>
        /// JNJNTDT3.
        /// </summary>
        public const string JNJNTDT3 = "JNJNTDT3";

        /// <summary>
        /// JNUSER.
        /// </summary>
        public const string JNUSER = "JNUSER";

        /// <summary>
        /// JNUPMJ.
        /// </summary>
        public const string JNUPMJ = "JNUPMJ";

        /// <summary>
        /// JNUPMT.
        /// </summary>
        public const string JNUPMT = "JNUPMT";

        /// <summary>
        /// JNPID.
        /// </summary>
        public const string JNPID = "JNPID";

        /// <summary>
        /// JNMKEY.
        /// </summary>
        public const string JNMKEY = "JNMKEY";
    }

    /// <inheritdoc />
    public override string TableName => "F09J123";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("JNUKID", "JNUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("JNJVSRCV", "JNJVSRCV", JdeDataType.String, 20),
        new JdeField("JNJVBASV", "JNJVBASV", JdeDataType.String, 20),
        new JdeField("JNSRCBUSTS", "JNSRCBUSTS", JdeDataType.String, 6),
        new JdeField("JNBASBUSTS", "JNBASBUSTS", JdeDataType.String, 6),
        new JdeField("JNSRCJVSTS", "JNSRCJVSTS", JdeDataType.String, 6),
        new JdeField("JNBASJVSTS", "JNBASJVSTS", JdeDataType.String, 6),
        new JdeField("JNSRCINDT", "JNSRCINDT", JdeDataType.Numeric),
        new JdeField("JNBASINDT", "JNBASINDT", JdeDataType.Numeric),
        new JdeField("JNURAB", "JNURAB", JdeDataType.Numeric),
        new JdeField("JNURCD", "JNURCD", JdeDataType.String, 4),
        new JdeField("JNURAT", "JNURAT", JdeDataType.Numeric),
        new JdeField("JNURDT", "JNURDT", JdeDataType.Numeric),
        new JdeField("JNURRF", "JNURRF", JdeDataType.String, 30),
        new JdeField("JNJNTNU1", "JNJNTNU1", JdeDataType.Numeric),
        new JdeField("JNJNTNU2", "JNJNTNU2", JdeDataType.Numeric),
        new JdeField("JNJNTNU3", "JNJNTNU3", JdeDataType.Numeric),
        new JdeField("JNJNTST1", "JNJNTST1", JdeDataType.String, 160),
        new JdeField("JNJNTST2", "JNJNTST2", JdeDataType.String, 160),
        new JdeField("JNJNTST3", "JNJNTST3", JdeDataType.String, 160),
        new JdeField("JNJNTCH1", "JNJNTCH1", JdeDataType.String, 2),
        new JdeField("JNJNTCH2", "JNJNTCH2", JdeDataType.String, 2),
        new JdeField("JNJNTCH3", "JNJNTCH3", JdeDataType.String, 2),
        new JdeField("JNJNTDT1", "JNJNTDT1", JdeDataType.Numeric),
        new JdeField("JNJNTDT2", "JNJNTDT2", JdeDataType.Numeric),
        new JdeField("JNJNTDT3", "JNJNTDT3", JdeDataType.Numeric),
        new JdeField("JNUSER", "JNUSER", JdeDataType.String, 20),
        new JdeField("JNUPMJ", "JNUPMJ", JdeDataType.Numeric),
        new JdeField("JNUPMT", "JNUPMT", JdeDataType.Numeric),
        new JdeField("JNPID", "JNPID", JdeDataType.String, 20),
        new JdeField("JNMKEY", "JNMKEY", JdeDataType.String, 30)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F09J123_0", "Primary Key on JNUKID", new[] { "JNUKID" }, isUnique: true, isPrimaryKey: true)
    };
}
