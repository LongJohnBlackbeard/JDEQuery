using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74P4010 - .
/// </summary>
public class F74P4010 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// DTDCT.
        /// </summary>
        public const string DTDCT = "DTDCT";

        /// <summary>
        /// DTP74DOCF.
        /// </summary>
        public const string DTP74DOCF = "DTP74DOCF";

        /// <summary>
        /// DTP74AN8F.
        /// </summary>
        public const string DTP74AN8F = "DTP74AN8F";

        /// <summary>
        /// DTP74AN8L.
        /// </summary>
        public const string DTP74AN8L = "DTP74AN8L";

        /// <summary>
        /// DTP74STDJ.
        /// </summary>
        public const string DTP74STDJ = "DTP74STDJ";

        /// <summary>
        /// DTUSER.
        /// </summary>
        public const string DTUSER = "DTUSER";

        /// <summary>
        /// DTPID.
        /// </summary>
        public const string DTPID = "DTPID";

        /// <summary>
        /// DTJOBN.
        /// </summary>
        public const string DTJOBN = "DTJOBN";

        /// <summary>
        /// DTUPMJ.
        /// </summary>
        public const string DTUPMJ = "DTUPMJ";

        /// <summary>
        /// DTUPMT.
        /// </summary>
        public const string DTUPMT = "DTUPMT";

        /// <summary>
        /// DTP74FAF.
        /// </summary>
        public const string DTP74FAF = "DTP74FAF";
    }

    /// <inheritdoc />
    public override string TableName => "F74P4010";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("DTDCT", "DTDCT", JdeDataType.String, 4, true, true),
        new JdeField("DTP74DOCF", "DTP74DOCF", JdeDataType.String, 2),
        new JdeField("DTP74AN8F", "DTP74AN8F", JdeDataType.String, 2),
        new JdeField("DTP74AN8L", "DTP74AN8L", JdeDataType.String, 2),
        new JdeField("DTP74STDJ", "DTP74STDJ", JdeDataType.String, 2),
        new JdeField("DTUSER", "DTUSER", JdeDataType.String, 20),
        new JdeField("DTPID", "DTPID", JdeDataType.String, 20),
        new JdeField("DTJOBN", "DTJOBN", JdeDataType.String, 20),
        new JdeField("DTUPMJ", "DTUPMJ", JdeDataType.Numeric),
        new JdeField("DTUPMT", "DTUPMT", JdeDataType.Numeric),
        new JdeField("DTP74FAF", "DTP74FAF", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74P4010_0", "Primary Key on DTDCT", new[] { "DTDCT" }, isUnique: true, isPrimaryKey: true)
    };
}
