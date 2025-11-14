using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74H501 - .
/// </summary>
public class F74H501 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CYLITM.
        /// </summary>
        public const string CYLITM = "CYLITM";

        /// <summary>
        /// CYMCU.
        /// </summary>
        public const string CYMCU = "CYMCU";

        /// <summary>
        /// CYH74CATTY.
        /// </summary>
        public const string CYH74CATTY = "CYH74CATTY";

        /// <summary>
        /// CYH74CATVL.
        /// </summary>
        public const string CYH74CATVL = "CYH74CATVL";

        /// <summary>
        /// CYUSER.
        /// </summary>
        public const string CYUSER = "CYUSER";

        /// <summary>
        /// CYPID.
        /// </summary>
        public const string CYPID = "CYPID";

        /// <summary>
        /// CYJOBN.
        /// </summary>
        public const string CYJOBN = "CYJOBN";

        /// <summary>
        /// CYUPMJ.
        /// </summary>
        public const string CYUPMJ = "CYUPMJ";

        /// <summary>
        /// CYUPMT.
        /// </summary>
        public const string CYUPMT = "CYUPMT";

        /// <summary>
        /// CYH74FUTDT.
        /// </summary>
        public const string CYH74FUTDT = "CYH74FUTDT";

        /// <summary>
        /// CYH74FUTNM.
        /// </summary>
        public const string CYH74FUTNM = "CYH74FUTNM";

        /// <summary>
        /// CYFUT6.
        /// </summary>
        public const string CYFUT6 = "CYFUT6";

        /// <summary>
        /// CYX2.
        /// </summary>
        public const string CYX2 = "CYX2";

        /// <summary>
        /// CYH74FUTCH.
        /// </summary>
        public const string CYH74FUTCH = "CYH74FUTCH";

        /// <summary>
        /// CYITM.
        /// </summary>
        public const string CYITM = "CYITM";
    }

    /// <inheritdoc />
    public override string TableName => "F74H501";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CYLITM", "CYLITM", JdeDataType.String, 50, true, true),
        new JdeField("CYMCU", "CYMCU", JdeDataType.String, 24, true, true),
        new JdeField("CYH74CATTY", "CYH74CATTY", JdeDataType.String, 20),
        new JdeField("CYH74CATVL", "CYH74CATVL", JdeDataType.String, 80),
        new JdeField("CYUSER", "CYUSER", JdeDataType.String, 20),
        new JdeField("CYPID", "CYPID", JdeDataType.String, 20),
        new JdeField("CYJOBN", "CYJOBN", JdeDataType.String, 20),
        new JdeField("CYUPMJ", "CYUPMJ", JdeDataType.Numeric),
        new JdeField("CYUPMT", "CYUPMT", JdeDataType.Numeric),
        new JdeField("CYH74FUTDT", "CYH74FUTDT", JdeDataType.Numeric),
        new JdeField("CYH74FUTNM", "CYH74FUTNM", JdeDataType.Numeric),
        new JdeField("CYFUT6", "CYFUT6", JdeDataType.String, 60),
        new JdeField("CYX2", "CYX2", JdeDataType.String, 2),
        new JdeField("CYH74FUTCH", "CYH74FUTCH", JdeDataType.String, 2),
        new JdeField("CYITM", "CYITM", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74H501_0", "Primary Key on CYLITM, CYMCU", new[] { "CYLITM", "CYMCU" }, isUnique: true, isPrimaryKey: true)
    };
}
