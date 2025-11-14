using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F0115 - .
/// </summary>
public class F0115 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WPAN8.
        /// </summary>
        public const string WPAN8 = "WPAN8";

        /// <summary>
        /// WPIDLN.
        /// </summary>
        public const string WPIDLN = "WPIDLN";

        /// <summary>
        /// WPRCK7.
        /// </summary>
        public const string WPRCK7 = "WPRCK7";

        /// <summary>
        /// WPCNLN.
        /// </summary>
        public const string WPCNLN = "WPCNLN";

        /// <summary>
        /// WPPHTP.
        /// </summary>
        public const string WPPHTP = "WPPHTP";

        /// <summary>
        /// WPAR1.
        /// </summary>
        public const string WPAR1 = "WPAR1";

        /// <summary>
        /// WPPH1.
        /// </summary>
        public const string WPPH1 = "WPPH1";

        /// <summary>
        /// WPUSER.
        /// </summary>
        public const string WPUSER = "WPUSER";

        /// <summary>
        /// WPPID.
        /// </summary>
        public const string WPPID = "WPPID";

        /// <summary>
        /// WPUPMJ.
        /// </summary>
        public const string WPUPMJ = "WPUPMJ";

        /// <summary>
        /// WPJOBN.
        /// </summary>
        public const string WPJOBN = "WPJOBN";

        /// <summary>
        /// WPUPMT.
        /// </summary>
        public const string WPUPMT = "WPUPMT";

        /// <summary>
        /// WPCFNO1.
        /// </summary>
        public const string WPCFNO1 = "WPCFNO1";

        /// <summary>
        /// WPGEN1.
        /// </summary>
        public const string WPGEN1 = "WPGEN1";

        /// <summary>
        /// WPFALGE.
        /// </summary>
        public const string WPFALGE = "WPFALGE";

        /// <summary>
        /// WPSYNCS.
        /// </summary>
        public const string WPSYNCS = "WPSYNCS";

        /// <summary>
        /// WPCAAD.
        /// </summary>
        public const string WPCAAD = "WPCAAD";
    }

    /// <inheritdoc />
    public override string TableName => "F0115";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WPAN8", "WPAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("WPIDLN", "WPIDLN", JdeDataType.Numeric, null, true, true),
        new JdeField("WPRCK7", "WPRCK7", JdeDataType.Numeric, null, true, true),
        new JdeField("WPCNLN", "WPCNLN", JdeDataType.Numeric, null, true, true),
        new JdeField("WPPHTP", "WPPHTP", JdeDataType.String, 8),
        new JdeField("WPAR1", "WPAR1", JdeDataType.String, 12),
        new JdeField("WPPH1", "WPPH1", JdeDataType.String, 40),
        new JdeField("WPUSER", "WPUSER", JdeDataType.String, 20),
        new JdeField("WPPID", "WPPID", JdeDataType.String, 20),
        new JdeField("WPUPMJ", "WPUPMJ", JdeDataType.Numeric),
        new JdeField("WPJOBN", "WPJOBN", JdeDataType.String, 20),
        new JdeField("WPUPMT", "WPUPMT", JdeDataType.Numeric),
        new JdeField("WPCFNO1", "WPCFNO1", JdeDataType.Numeric),
        new JdeField("WPGEN1", "WPGEN1", JdeDataType.String, 20),
        new JdeField("WPFALGE", "WPFALGE", JdeDataType.String, 2),
        new JdeField("WPSYNCS", "WPSYNCS", JdeDataType.Numeric),
        new JdeField("WPCAAD", "WPCAAD", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F0115_0", "Primary Key on WPAN8, WPIDLN, WPCNLN, WPRCK7", new[] { "WPAN8", "WPIDLN", "WPCNLN", "WPRCK7" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F0115_2", "Index on WPAN8, WPIDLN, WPCNLN, WPPHTP", new[] { "WPAN8", "WPIDLN", "WPCNLN", "WPPHTP" }),
        new JdeIndex("F0115_3", "Index on WPAN8, WPIDLN, WPPHTP", new[] { "WPAN8", "WPIDLN", "WPPHTP" })
    };
}
