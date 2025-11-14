using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F743013Z - .
/// </summary>
public class F743013Z : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TKEDUS.
        /// </summary>
        public const string TKEDUS = "TKEDUS";

        /// <summary>
        /// TKEDBT.
        /// </summary>
        public const string TKEDBT = "TKEDBT";

        /// <summary>
        /// TKEDTN.
        /// </summary>
        public const string TKEDTN = "TKEDTN";

        /// <summary>
        /// TKK74SSIGN.
        /// </summary>
        public const string TKK74SSIGN = "TKK74SSIGN";

        /// <summary>
        /// TKK74PKV.
        /// </summary>
        public const string TKK74PKV = "TKK74PKV";

        /// <summary>
        /// TKK74SED.
        /// </summary>
        public const string TKK74SED = "TKK74SED";

        /// <summary>
        /// TKK74FLEN.
        /// </summary>
        public const string TKK74FLEN = "TKK74FLEN";

        /// <summary>
        /// TKK74CNO.
        /// </summary>
        public const string TKK74CNO = "TKK74CNO";

        /// <summary>
        /// TKJOBN.
        /// </summary>
        public const string TKJOBN = "TKJOBN";

        /// <summary>
        /// TKTORG.
        /// </summary>
        public const string TKTORG = "TKTORG";

        /// <summary>
        /// TKPID.
        /// </summary>
        public const string TKPID = "TKPID";

        /// <summary>
        /// TKUSER.
        /// </summary>
        public const string TKUSER = "TKUSER";

        /// <summary>
        /// TKUPMJ.
        /// </summary>
        public const string TKUPMJ = "TKUPMJ";

        /// <summary>
        /// TKUPMT.
        /// </summary>
        public const string TKUPMT = "TKUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F743013Z";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TKEDUS", "TKEDUS", JdeDataType.String, 20, true, true),
        new JdeField("TKEDBT", "TKEDBT", JdeDataType.String, 30, true, true),
        new JdeField("TKEDTN", "TKEDTN", JdeDataType.String, 44, true, true),
        new JdeField("TKK74SSIGN", "TKK74SSIGN", JdeDataType.String, 2000),
        new JdeField("TKK74PKV", "TKK74PKV", JdeDataType.Numeric),
        new JdeField("TKK74SED", "TKK74SED", JdeDataType.Numeric),
        new JdeField("TKK74FLEN", "TKK74FLEN", JdeDataType.String, 50),
        new JdeField("TKK74CNO", "TKK74CNO", JdeDataType.String, 40),
        new JdeField("TKJOBN", "TKJOBN", JdeDataType.String, 20),
        new JdeField("TKTORG", "TKTORG", JdeDataType.String, 20),
        new JdeField("TKPID", "TKPID", JdeDataType.String, 20),
        new JdeField("TKUSER", "TKUSER", JdeDataType.String, 20),
        new JdeField("TKUPMJ", "TKUPMJ", JdeDataType.Numeric),
        new JdeField("TKUPMT", "TKUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F743013Z_0", "Primary Key on TKEDUS, TKEDBT, TKEDTN", new[] { "TKEDUS", "TKEDBT", "TKEDTN" }, isUnique: true, isPrimaryKey: true)
    };
}
