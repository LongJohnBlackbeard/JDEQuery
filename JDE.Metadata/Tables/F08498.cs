using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F08498 - .
/// </summary>
public class F08498 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// APNURC.
        /// </summary>
        public const string APNURC = "APNURC";

        /// <summary>
        /// APPSTNO.
        /// </summary>
        public const string APPSTNO = "APPSTNO";

        /// <summary>
        /// APAN8.
        /// </summary>
        public const string APAN8 = "APAN8";

        /// <summary>
        /// APAPPSTS.
        /// </summary>
        public const string APAPPSTS = "APAPPSTS";

        /// <summary>
        /// APRCDATE.
        /// </summary>
        public const string APRCDATE = "APRCDATE";

        /// <summary>
        /// APRCLF.
        /// </summary>
        public const string APRCLF = "APRCLF";

        /// <summary>
        /// APPID.
        /// </summary>
        public const string APPID = "APPID";

        /// <summary>
        /// APUSER.
        /// </summary>
        public const string APUSER = "APUSER";

        /// <summary>
        /// APMKEY.
        /// </summary>
        public const string APMKEY = "APMKEY";

        /// <summary>
        /// APUPMJ.
        /// </summary>
        public const string APUPMJ = "APUPMJ";

        /// <summary>
        /// APUPMT.
        /// </summary>
        public const string APUPMT = "APUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F08498";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("APNURC", "APNURC", JdeDataType.Numeric, null, true, true),
        new JdeField("APPSTNO", "APPSTNO", JdeDataType.Numeric, null, true, true),
        new JdeField("APAN8", "APAN8", JdeDataType.Numeric),
        new JdeField("APAPPSTS", "APAPPSTS", JdeDataType.String, 2),
        new JdeField("APRCDATE", "APRCDATE", JdeDataType.Numeric),
        new JdeField("APRCLF", "APRCLF", JdeDataType.String, 2),
        new JdeField("APPID", "APPID", JdeDataType.String, 20),
        new JdeField("APUSER", "APUSER", JdeDataType.String, 20),
        new JdeField("APMKEY", "APMKEY", JdeDataType.String, 30),
        new JdeField("APUPMJ", "APUPMJ", JdeDataType.Numeric),
        new JdeField("APUPMT", "APUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F08498_0", "Primary Key on APNURC, APPSTNO", new[] { "APNURC", "APPSTNO" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F08498_2", "Index on APNURC", new[] { "APNURC" })
    };
}
