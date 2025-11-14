using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F42X010 - .
/// </summary>
public class F42X010 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// FOAN8.
        /// </summary>
        public const string FOAN8 = "FOAN8";

        /// <summary>
        /// FOCO.
        /// </summary>
        public const string FOCO = "FOCO";

        /// <summary>
        /// FOITM.
        /// </summary>
        public const string FOITM = "FOITM";

        /// <summary>
        /// FOCENTYR.
        /// </summary>
        public const string FOCENTYR = "FOCENTYR";

        /// <summary>
        /// FOMT.
        /// </summary>
        public const string FOMT = "FOMT";

        /// <summary>
        /// FO42XRDCT.
        /// </summary>
        public const string FO42XRDCT = "FO42XRDCT";

        /// <summary>
        /// FOUSER.
        /// </summary>
        public const string FOUSER = "FOUSER";

        /// <summary>
        /// FOPID.
        /// </summary>
        public const string FOPID = "FOPID";

        /// <summary>
        /// FOJOBN.
        /// </summary>
        public const string FOJOBN = "FOJOBN";

        /// <summary>
        /// FOUPMJ.
        /// </summary>
        public const string FOUPMJ = "FOUPMJ";

        /// <summary>
        /// FOTDAY.
        /// </summary>
        public const string FOTDAY = "FOTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F42X010";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("FOAN8", "FOAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("FOCO", "FOCO", JdeDataType.String, 10, true, true),
        new JdeField("FOITM", "FOITM", JdeDataType.Numeric, null, true, true),
        new JdeField("FOCENTYR", "FOCENTYR", JdeDataType.Numeric, null, true, true),
        new JdeField("FOMT", "FOMT", JdeDataType.Numeric, null, true, true),
        new JdeField("FO42XRDCT", "FO42XRDCT", JdeDataType.Numeric),
        new JdeField("FOUSER", "FOUSER", JdeDataType.String, 20),
        new JdeField("FOPID", "FOPID", JdeDataType.String, 20),
        new JdeField("FOJOBN", "FOJOBN", JdeDataType.String, 20),
        new JdeField("FOUPMJ", "FOUPMJ", JdeDataType.Numeric),
        new JdeField("FOTDAY", "FOTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F42X010_0", "Primary Key on FOAN8, FOCO, FOITM, FOCENTYR, FOMT", new[] { "FOAN8", "FOCO", "FOITM", "FOCENTYR", "FOMT" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F42X010_2", "Index on FOAN8, FOCO, FOITM, FOCENTYR, FOMT, SYS_NC00012$", new[] { "FOAN8", "FOCO", "FOITM", "FOCENTYR", "FOMT", "SYS_NC00012$" }),
        new JdeIndex("F42X010_3", "Index on FOCENTYR, FOMT", new[] { "FOCENTYR", "FOMT" })
    };
}
