using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F40G70 - .
/// </summary>
public class F40G70 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WHWOPID.
        /// </summary>
        public const string WHWOPID = "WHWOPID";

        /// <summary>
        /// WHWVID.
        /// </summary>
        public const string WHWVID = "WHWVID";

        /// <summary>
        /// WHFOSDT.
        /// </summary>
        public const string WHFOSDT = "WHFOSDT";

        /// <summary>
        /// WHFOEDT.
        /// </summary>
        public const string WHFOEDT = "WHFOEDT";

        /// <summary>
        /// WHWOPST.
        /// </summary>
        public const string WHWOPST = "WHWOPST";

        /// <summary>
        /// WHREWHSDT.
        /// </summary>
        public const string WHREWHSDT = "WHREWHSDT";

        /// <summary>
        /// WHREWHEDT.
        /// </summary>
        public const string WHREWHEDT = "WHREWHEDT";

        /// <summary>
        /// WHREBLK.
        /// </summary>
        public const string WHREBLK = "WHREBLK";

        /// <summary>
        /// WHVALREN.
        /// </summary>
        public const string WHVALREN = "WHVALREN";

        /// <summary>
        /// WHSUBWHSDT.
        /// </summary>
        public const string WHSUBWHSDT = "WHSUBWHSDT";

        /// <summary>
        /// WHSUBWHEDT.
        /// </summary>
        public const string WHSUBWHEDT = "WHSUBWHEDT";

        /// <summary>
        /// WHSUBACT.
        /// </summary>
        public const string WHSUBACT = "WHSUBACT";

        /// <summary>
        /// WHVALSUB.
        /// </summary>
        public const string WHVALSUB = "WHVALSUB";

        /// <summary>
        /// WHHARWHSDT.
        /// </summary>
        public const string WHHARWHSDT = "WHHARWHSDT";

        /// <summary>
        /// WHHARWHEDT.
        /// </summary>
        public const string WHHARWHEDT = "WHHARWHEDT";

        /// <summary>
        /// WHHARACT.
        /// </summary>
        public const string WHHARACT = "WHHARACT";

        /// <summary>
        /// WHVALHAR.
        /// </summary>
        public const string WHVALHAR = "WHVALHAR";

        /// <summary>
        /// WHPRWHSDT.
        /// </summary>
        public const string WHPRWHSDT = "WHPRWHSDT";

        /// <summary>
        /// WHPRWHEDT.
        /// </summary>
        public const string WHPRWHEDT = "WHPRWHEDT";

        /// <summary>
        /// WHPRACT.
        /// </summary>
        public const string WHPRACT = "WHPRACT";

        /// <summary>
        /// WHVALPRR.
        /// </summary>
        public const string WHVALPRR = "WHVALPRR";

        /// <summary>
        /// WHUSER.
        /// </summary>
        public const string WHUSER = "WHUSER";

        /// <summary>
        /// WHTORG.
        /// </summary>
        public const string WHTORG = "WHTORG";

        /// <summary>
        /// WHPID.
        /// </summary>
        public const string WHPID = "WHPID";

        /// <summary>
        /// WHJOBN.
        /// </summary>
        public const string WHJOBN = "WHJOBN";

        /// <summary>
        /// WHUUPMJ.
        /// </summary>
        public const string WHUUPMJ = "WHUUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "F40G70";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WHWOPID", "WHWOPID", JdeDataType.Numeric, null, true, true),
        new JdeField("WHWVID", "WHWVID", JdeDataType.Numeric, null, true, true),
        new JdeField("WHFOSDT", "WHFOSDT", JdeDataType.Date),
        new JdeField("WHFOEDT", "WHFOEDT", JdeDataType.Date),
        new JdeField("WHWOPST", "WHWOPST", JdeDataType.String, 20),
        new JdeField("WHREWHSDT", "WHREWHSDT", JdeDataType.Date),
        new JdeField("WHREWHEDT", "WHREWHEDT", JdeDataType.Date),
        new JdeField("WHREBLK", "WHREBLK", JdeDataType.Numeric),
        new JdeField("WHVALREN", "WHVALREN", JdeDataType.String, 2),
        new JdeField("WHSUBWHSDT", "WHSUBWHSDT", JdeDataType.Date),
        new JdeField("WHSUBWHEDT", "WHSUBWHEDT", JdeDataType.Date),
        new JdeField("WHSUBACT", "WHSUBACT", JdeDataType.Numeric),
        new JdeField("WHVALSUB", "WHVALSUB", JdeDataType.String, 2),
        new JdeField("WHHARWHSDT", "WHHARWHSDT", JdeDataType.Date),
        new JdeField("WHHARWHEDT", "WHHARWHEDT", JdeDataType.Date),
        new JdeField("WHHARACT", "WHHARACT", JdeDataType.Numeric),
        new JdeField("WHVALHAR", "WHVALHAR", JdeDataType.String, 2),
        new JdeField("WHPRWHSDT", "WHPRWHSDT", JdeDataType.Date),
        new JdeField("WHPRWHEDT", "WHPRWHEDT", JdeDataType.Date),
        new JdeField("WHPRACT", "WHPRACT", JdeDataType.Numeric),
        new JdeField("WHVALPRR", "WHVALPRR", JdeDataType.String, 2),
        new JdeField("WHUSER", "WHUSER", JdeDataType.String, 20),
        new JdeField("WHTORG", "WHTORG", JdeDataType.String, 20),
        new JdeField("WHPID", "WHPID", JdeDataType.String, 20),
        new JdeField("WHJOBN", "WHJOBN", JdeDataType.String, 20),
        new JdeField("WHUUPMJ", "WHUUPMJ", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F40G70_0", "Primary Key on WHWOPID, WHWVID", new[] { "WHWOPID", "WHWVID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F40G70_2", "Index on WHWVID, WHFOSDT, WHFOEDT", new[] { "WHWVID", "WHFOSDT", "WHFOEDT" })
    };
}
