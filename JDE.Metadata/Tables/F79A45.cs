using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F79A45 - .
/// </summary>
public class F79A45 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// KT79AKTID.
        /// </summary>
        public const string KT79AKTID = "KT79AKTID";

        /// <summary>
        /// KT79AGKPID.
        /// </summary>
        public const string KT79AGKPID = "KT79AGKPID";

        /// <summary>
        /// KT79AGOID.
        /// </summary>
        public const string KT79AGOID = "KT79AGOID";

        /// <summary>
        /// KT79ATG.
        /// </summary>
        public const string KT79ATG = "KT79ATG";

        /// <summary>
        /// KT79ATV.
        /// </summary>
        public const string KT79ATV = "KT79ATV";

        /// <summary>
        /// KT79AGUM.
        /// </summary>
        public const string KT79AGUM = "KT79AGUM";

        /// <summary>
        /// KTBEFD.
        /// </summary>
        public const string KTBEFD = "KTBEFD";

        /// <summary>
        /// KTEEFD.
        /// </summary>
        public const string KTEEFD = "KTEEFD";

        /// <summary>
        /// KTPID.
        /// </summary>
        public const string KTPID = "KTPID";

        /// <summary>
        /// KTUSER.
        /// </summary>
        public const string KTUSER = "KTUSER";

        /// <summary>
        /// KTJOBN.
        /// </summary>
        public const string KTJOBN = "KTJOBN";

        /// <summary>
        /// KTUPMJ.
        /// </summary>
        public const string KTUPMJ = "KTUPMJ";

        /// <summary>
        /// KTUPMT.
        /// </summary>
        public const string KTUPMT = "KTUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F79A45";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("KT79AKTID", "KT79AKTID", JdeDataType.Numeric, null, true, true),
        new JdeField("KT79AGKPID", "KT79AGKPID", JdeDataType.Numeric),
        new JdeField("KT79AGOID", "KT79AGOID", JdeDataType.Numeric),
        new JdeField("KT79ATG", "KT79ATG", JdeDataType.String, 60),
        new JdeField("KT79ATV", "KT79ATV", JdeDataType.Numeric),
        new JdeField("KT79AGUM", "KT79AGUM", JdeDataType.String, 30),
        new JdeField("KTBEFD", "KTBEFD", JdeDataType.Numeric),
        new JdeField("KTEEFD", "KTEEFD", JdeDataType.Numeric),
        new JdeField("KTPID", "KTPID", JdeDataType.String, 20),
        new JdeField("KTUSER", "KTUSER", JdeDataType.String, 20),
        new JdeField("KTJOBN", "KTJOBN", JdeDataType.String, 20),
        new JdeField("KTUPMJ", "KTUPMJ", JdeDataType.Numeric),
        new JdeField("KTUPMT", "KTUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F79A45_0", "Primary Key on KT79AKTID", new[] { "KT79AKTID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F79A45_4", "Index on KT79AGKPID, KT79AGOID, KT79ATG", new[] { "KT79AGKPID", "KT79AGOID", "KT79ATG" }),
        new JdeIndex("F79A45_5", "Unique Index on KT79AGKPID, KT79AGOID, KT79ATG, KTBEFD", new[] { "KT79AGKPID", "KT79AGOID", "KT79ATG", "KTBEFD" }, isUnique: true),
        new JdeIndex("F79A45_6", "Index on KT79AGKPID", new[] { "KT79AGKPID" }),
        new JdeIndex("F79A45_7", "Index on KT79AGOID", new[] { "KT79AGOID" })
    };
}
