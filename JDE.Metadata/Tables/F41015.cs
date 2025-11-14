using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F41015 - .
/// </summary>
public class F41015 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// BAITM.
        /// </summary>
        public const string BAITM = "BAITM";

        /// <summary>
        /// BAMCU.
        /// </summary>
        public const string BAMCU = "BAMCU";

        /// <summary>
        /// BAMCU2.
        /// </summary>
        public const string BAMCU2 = "BAMCU2";

        /// <summary>
        /// BADL01.
        /// </summary>
        public const string BADL01 = "BADL01";

        /// <summary>
        /// BAUSER.
        /// </summary>
        public const string BAUSER = "BAUSER";

        /// <summary>
        /// BAPID.
        /// </summary>
        public const string BAPID = "BAPID";

        /// <summary>
        /// BAJOBN.
        /// </summary>
        public const string BAJOBN = "BAJOBN";

        /// <summary>
        /// BAUPMJ.
        /// </summary>
        public const string BAUPMJ = "BAUPMJ";

        /// <summary>
        /// BATDAY.
        /// </summary>
        public const string BATDAY = "BATDAY";

        /// <summary>
        /// BALAF.
        /// </summary>
        public const string BALAF = "BALAF";

        /// <summary>
        /// BALTFM.
        /// </summary>
        public const string BALTFM = "BALTFM";

        /// <summary>
        /// BARWLA.
        /// </summary>
        public const string BARWLA = "BARWLA";
    }

    /// <inheritdoc />
    public override string TableName => "F41015";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("BAITM", "BAITM", JdeDataType.Numeric, null, true, true),
        new JdeField("BAMCU", "BAMCU", JdeDataType.String, 24, true, true),
        new JdeField("BAMCU2", "BAMCU2", JdeDataType.String, 24, true, true),
        new JdeField("BADL01", "BADL01", JdeDataType.String, 60),
        new JdeField("BAUSER", "BAUSER", JdeDataType.String, 20, true, true),
        new JdeField("BAPID", "BAPID", JdeDataType.String, 20),
        new JdeField("BAJOBN", "BAJOBN", JdeDataType.String, 20, true, true),
        new JdeField("BAUPMJ", "BAUPMJ", JdeDataType.Numeric, null, true, true),
        new JdeField("BATDAY", "BATDAY", JdeDataType.Numeric, null, true, true),
        new JdeField("BALAF", "BALAF", JdeDataType.String, 2),
        new JdeField("BALTFM", "BALTFM", JdeDataType.String, 2),
        new JdeField("BARWLA", "BARWLA", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F41015_0", "Primary Key on BAITM, BAMCU, BAMCU2, BAUSER, BAJOBN, BAUPMJ, BATDAY", new[] { "BAITM", "BAMCU", "BAMCU2", "BAUSER", "BAJOBN", "BAUPMJ", "BATDAY" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F41015_2", "Index on BAUSER, BAJOBN, BAUPMJ, BATDAY", new[] { "BAUSER", "BAJOBN", "BAUPMJ", "BATDAY" })
    };
}
