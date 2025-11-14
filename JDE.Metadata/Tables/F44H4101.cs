using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F44H4101 - .
/// </summary>
public class F44H4101 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// HIITM.
        /// </summary>
        public const string HIITM = "HIITM";

        /// <summary>
        /// HIHBAREA.
        /// </summary>
        public const string HIHBAREA = "HIHBAREA";

        /// <summary>
        /// HITX.
        /// </summary>
        public const string HITX = "HITX";

        /// <summary>
        /// HIHBDEFPR.
        /// </summary>
        public const string HIHBDEFPR = "HIHBDEFPR";

        /// <summary>
        /// HIHBPRFCTR.
        /// </summary>
        public const string HIHBPRFCTR = "HIHBPRFCTR";

        /// <summary>
        /// HIHBDEFSP.
        /// </summary>
        public const string HIHBDEFSP = "HIHBDEFSP";

        /// <summary>
        /// HIHBDEFCC.
        /// </summary>
        public const string HIHBDEFCC = "HIHBDEFCC";

        /// <summary>
        /// HIHBICC1.
        /// </summary>
        public const string HIHBICC1 = "HIHBICC1";

        /// <summary>
        /// HIHBICC2.
        /// </summary>
        public const string HIHBICC2 = "HIHBICC2";

        /// <summary>
        /// HIHBICC3.
        /// </summary>
        public const string HIHBICC3 = "HIHBICC3";

        /// <summary>
        /// HIHBICC4.
        /// </summary>
        public const string HIHBICC4 = "HIHBICC4";

        /// <summary>
        /// HIHBICC5.
        /// </summary>
        public const string HIHBICC5 = "HIHBICC5";

        /// <summary>
        /// HICRTU.
        /// </summary>
        public const string HICRTU = "HICRTU";

        /// <summary>
        /// HICRTJ.
        /// </summary>
        public const string HICRTJ = "HICRTJ";

        /// <summary>
        /// HICRTT.
        /// </summary>
        public const string HICRTT = "HICRTT";

        /// <summary>
        /// HIWRKSTNID.
        /// </summary>
        public const string HIWRKSTNID = "HIWRKSTNID";

        /// <summary>
        /// HIHBOPID.
        /// </summary>
        public const string HIHBOPID = "HIHBOPID";

        /// <summary>
        /// HIUPMB.
        /// </summary>
        public const string HIUPMB = "HIUPMB";

        /// <summary>
        /// HIUPMJ.
        /// </summary>
        public const string HIUPMJ = "HIUPMJ";

        /// <summary>
        /// HIUPMT.
        /// </summary>
        public const string HIUPMT = "HIUPMT";

        /// <summary>
        /// HIJOBN.
        /// </summary>
        public const string HIJOBN = "HIJOBN";

        /// <summary>
        /// HIPID.
        /// </summary>
        public const string HIPID = "HIPID";

        /// <summary>
        /// HINPC.
        /// </summary>
        public const string HINPC = "HINPC";
    }

    /// <inheritdoc />
    public override string TableName => "F44H4101";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("HIITM", "HIITM", JdeDataType.Numeric, null, true, true),
        new JdeField("HIHBAREA", "HIHBAREA", JdeDataType.String, 6, true, true),
        new JdeField("HITX", "HITX", JdeDataType.String, 2),
        new JdeField("HIHBDEFPR", "HIHBDEFPR", JdeDataType.Numeric),
        new JdeField("HIHBPRFCTR", "HIHBPRFCTR", JdeDataType.Numeric),
        new JdeField("HIHBDEFSP", "HIHBDEFSP", JdeDataType.Numeric),
        new JdeField("HIHBDEFCC", "HIHBDEFCC", JdeDataType.String, 16),
        new JdeField("HIHBICC1", "HIHBICC1", JdeDataType.String, 6),
        new JdeField("HIHBICC2", "HIHBICC2", JdeDataType.String, 6),
        new JdeField("HIHBICC3", "HIHBICC3", JdeDataType.String, 6),
        new JdeField("HIHBICC4", "HIHBICC4", JdeDataType.String, 6),
        new JdeField("HIHBICC5", "HIHBICC5", JdeDataType.String, 6),
        new JdeField("HICRTU", "HICRTU", JdeDataType.String, 20),
        new JdeField("HICRTJ", "HICRTJ", JdeDataType.Numeric),
        new JdeField("HICRTT", "HICRTT", JdeDataType.Numeric),
        new JdeField("HIWRKSTNID", "HIWRKSTNID", JdeDataType.String, 20),
        new JdeField("HIHBOPID", "HIHBOPID", JdeDataType.String, 20),
        new JdeField("HIUPMB", "HIUPMB", JdeDataType.String, 20),
        new JdeField("HIUPMJ", "HIUPMJ", JdeDataType.Numeric),
        new JdeField("HIUPMT", "HIUPMT", JdeDataType.Numeric),
        new JdeField("HIJOBN", "HIJOBN", JdeDataType.String, 20),
        new JdeField("HIPID", "HIPID", JdeDataType.String, 20),
        new JdeField("HINPC", "HINPC", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F44H4101_0", "Primary Key on HIITM, HIHBAREA", new[] { "HIITM", "HIHBAREA" }, isUnique: true, isPrimaryKey: true)
    };
}
