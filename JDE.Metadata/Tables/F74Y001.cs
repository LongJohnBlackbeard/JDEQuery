using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74Y001 - .
/// </summary>
public class F74Y001 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CIAN8.
        /// </summary>
        public const string CIAN8 = "CIAN8";

        /// <summary>
        /// CIY74FTAX.
        /// </summary>
        public const string CIY74FTAX = "CIY74FTAX";

        /// <summary>
        /// CIY74COJT.
        /// </summary>
        public const string CIY74COJT = "CIY74COJT";

        /// <summary>
        /// CIY74SOTX.
        /// </summary>
        public const string CIY74SOTX = "CIY74SOTX";

        /// <summary>
        /// CIY74DAN8.
        /// </summary>
        public const string CIY74DAN8 = "CIY74DAN8";

        /// <summary>
        /// CIY74DEPC.
        /// </summary>
        public const string CIY74DEPC = "CIY74DEPC";

        /// <summary>
        /// CIY74IAN8.
        /// </summary>
        public const string CIY74IAN8 = "CIY74IAN8";

        /// <summary>
        /// CIY74ICAF.
        /// </summary>
        public const string CIY74ICAF = "CIY74ICAF";

        /// <summary>
        /// CIY74ICDT.
        /// </summary>
        public const string CIY74ICDT = "CIY74ICDT";

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
    public override string TableName => "F74Y001";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CIAN8", "CIAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("CIY74FTAX", "CIY74FTAX", JdeDataType.String, 48),
        new JdeField("CIY74COJT", "CIY74COJT", JdeDataType.Numeric),
        new JdeField("CIY74SOTX", "CIY74SOTX", JdeDataType.String, 32),
        new JdeField("CIY74DAN8", "CIY74DAN8", JdeDataType.Numeric),
        new JdeField("CIY74DEPC", "CIY74DEPC", JdeDataType.Numeric),
        new JdeField("CIY74IAN8", "CIY74IAN8", JdeDataType.Numeric),
        new JdeField("CIY74ICAF", "CIY74ICAF", JdeDataType.Numeric),
        new JdeField("CIY74ICDT", "CIY74ICDT", JdeDataType.Numeric),
        new JdeField("CIUSER", "CIUSER", JdeDataType.String, 20),
        new JdeField("CIPID", "CIPID", JdeDataType.String, 20),
        new JdeField("CIJOBN", "CIJOBN", JdeDataType.String, 20),
        new JdeField("CIUPMJ", "CIUPMJ", JdeDataType.Numeric),
        new JdeField("CIUPMT", "CIUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74Y001_0", "Primary Key on CIAN8", new[] { "CIAN8" }, isUnique: true, isPrimaryKey: true)
    };
}
