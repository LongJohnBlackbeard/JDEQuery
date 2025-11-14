using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F080705 - .
/// </summary>
public class F080705 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// FTCONFID.
        /// </summary>
        public const string FTCONFID = "FTCONFID";

        /// <summary>
        /// FTTRNTY.
        /// </summary>
        public const string FTTRNTY = "FTTRNTY";

        /// <summary>
        /// FTTRNST.
        /// </summary>
        public const string FTTRNST = "FTTRNST";

        /// <summary>
        /// FTZIPFN.
        /// </summary>
        public const string FTZIPFN = "FTZIPFN";

        /// <summary>
        /// FTUSER.
        /// </summary>
        public const string FTUSER = "FTUSER";

        /// <summary>
        /// FTUPMJ.
        /// </summary>
        public const string FTUPMJ = "FTUPMJ";

        /// <summary>
        /// FTUPMT.
        /// </summary>
        public const string FTUPMT = "FTUPMT";

        /// <summary>
        /// FTJOBN.
        /// </summary>
        public const string FTJOBN = "FTJOBN";

        /// <summary>
        /// FTPID.
        /// </summary>
        public const string FTPID = "FTPID";

        /// <summary>
        /// FTLINENUM.
        /// </summary>
        public const string FTLINENUM = "FTLINENUM";
    }

    /// <inheritdoc />
    public override string TableName => "F080705";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("FTCONFID", "FTCONFID", JdeDataType.Numeric, null, true, true),
        new JdeField("FTTRNTY", "FTTRNTY", JdeDataType.String, 30, true, true),
        new JdeField("FTTRNST", "FTTRNST", JdeDataType.String, 2),
        new JdeField("FTZIPFN", "FTZIPFN", JdeDataType.String, 500),
        new JdeField("FTUSER", "FTUSER", JdeDataType.String, 20),
        new JdeField("FTUPMJ", "FTUPMJ", JdeDataType.Numeric),
        new JdeField("FTUPMT", "FTUPMT", JdeDataType.Numeric),
        new JdeField("FTJOBN", "FTJOBN", JdeDataType.String, 20),
        new JdeField("FTPID", "FTPID", JdeDataType.String, 20),
        new JdeField("FTLINENUM", "FTLINENUM", JdeDataType.Numeric, null, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F080705_0", "Primary Key on FTCONFID, FTTRNTY, FTLINENUM", new[] { "FTCONFID", "FTTRNTY", "FTLINENUM" }, isUnique: true, isPrimaryKey: true)
    };
}
