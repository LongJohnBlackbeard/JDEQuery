using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74U0430 - .
/// </summary>
public class F74U0430 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SGLTNA.
        /// </summary>
        public const string SGLTNA = "SGLTNA";

        /// <summary>
        /// SG74ULTTY.
        /// </summary>
        public const string SG74ULTTY = "SG74ULTTY";

        /// <summary>
        /// SGNDLATE.
        /// </summary>
        public const string SGNDLATE = "SGNDLATE";

        /// <summary>
        /// SGLNGP.
        /// </summary>
        public const string SGLNGP = "SGLNGP";

        /// <summary>
        /// SGDESC.
        /// </summary>
        public const string SGDESC = "SGDESC";

        /// <summary>
        /// SGURAB.
        /// </summary>
        public const string SGURAB = "SGURAB";

        /// <summary>
        /// SGURAT.
        /// </summary>
        public const string SGURAT = "SGURAT";

        /// <summary>
        /// SGURCD.
        /// </summary>
        public const string SGURCD = "SGURCD";

        /// <summary>
        /// SGURRF.
        /// </summary>
        public const string SGURRF = "SGURRF";

        /// <summary>
        /// SGURDT.
        /// </summary>
        public const string SGURDT = "SGURDT";

        /// <summary>
        /// SGUSER.
        /// </summary>
        public const string SGUSER = "SGUSER";

        /// <summary>
        /// SGPID.
        /// </summary>
        public const string SGPID = "SGPID";

        /// <summary>
        /// SGJOBN.
        /// </summary>
        public const string SGJOBN = "SGJOBN";

        /// <summary>
        /// SGUPMJ.
        /// </summary>
        public const string SGUPMJ = "SGUPMJ";

        /// <summary>
        /// SGUPMT.
        /// </summary>
        public const string SGUPMT = "SGUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F74U0430";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SGLTNA", "SGLTNA", JdeDataType.String, 20, true, true),
        new JdeField("SG74ULTTY", "SG74ULTTY", JdeDataType.String, 2, true, true),
        new JdeField("SGNDLATE", "SGNDLATE", JdeDataType.Numeric, null, true, true),
        new JdeField("SGLNGP", "SGLNGP", JdeDataType.String, 4, true, true),
        new JdeField("SGDESC", "SGDESC", JdeDataType.String, 60),
        new JdeField("SGURAB", "SGURAB", JdeDataType.Numeric),
        new JdeField("SGURAT", "SGURAT", JdeDataType.Numeric),
        new JdeField("SGURCD", "SGURCD", JdeDataType.String, 4),
        new JdeField("SGURRF", "SGURRF", JdeDataType.String, 30),
        new JdeField("SGURDT", "SGURDT", JdeDataType.Numeric),
        new JdeField("SGUSER", "SGUSER", JdeDataType.String, 20),
        new JdeField("SGPID", "SGPID", JdeDataType.String, 20),
        new JdeField("SGJOBN", "SGJOBN", JdeDataType.String, 20),
        new JdeField("SGUPMJ", "SGUPMJ", JdeDataType.Numeric),
        new JdeField("SGUPMT", "SGUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74U0430_0", "Primary Key on SGLTNA, SG74ULTTY, SGLNGP, SGNDLATE", new[] { "SGLTNA", "SG74ULTTY", "SGLNGP", "SGNDLATE" }, isUnique: true, isPrimaryKey: true)
    };
}
