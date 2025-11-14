using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F09302 - .
/// </summary>
public class F09302 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// OCSY.
        /// </summary>
        public const string OCSY = "OCSY";

        /// <summary>
        /// OCERDF.
        /// </summary>
        public const string OCERDF = "OCERDF";

        /// <summary>
        /// OCECDF.
        /// </summary>
        public const string OCECDF = "OCECDF";

        /// <summary>
        /// OCOCCT1.
        /// </summary>
        public const string OCOCCT1 = "OCOCCT1";

        /// <summary>
        /// OCOCCT2.
        /// </summary>
        public const string OCOCCT2 = "OCOCCT2";

        /// <summary>
        /// OCOCCT3.
        /// </summary>
        public const string OCOCCT3 = "OCOCCT3";

        /// <summary>
        /// OCOCCT4.
        /// </summary>
        public const string OCOCCT4 = "OCOCCT4";

        /// <summary>
        /// OCOCCT5.
        /// </summary>
        public const string OCOCCT5 = "OCOCCT5";

        /// <summary>
        /// OCOCCT6.
        /// </summary>
        public const string OCOCCT6 = "OCOCCT6";

        /// <summary>
        /// OCOCST1.
        /// </summary>
        public const string OCOCST1 = "OCOCST1";

        /// <summary>
        /// OCOCST2.
        /// </summary>
        public const string OCOCST2 = "OCOCST2";

        /// <summary>
        /// OCOCST3.
        /// </summary>
        public const string OCOCST3 = "OCOCST3";

        /// <summary>
        /// OCOCDT1.
        /// </summary>
        public const string OCOCDT1 = "OCOCDT1";

        /// <summary>
        /// OCOCDT2.
        /// </summary>
        public const string OCOCDT2 = "OCOCDT2";

        /// <summary>
        /// OCOCDT3.
        /// </summary>
        public const string OCOCDT3 = "OCOCDT3";

        /// <summary>
        /// OCOCNU1.
        /// </summary>
        public const string OCOCNU1 = "OCOCNU1";

        /// <summary>
        /// OCOCNU2.
        /// </summary>
        public const string OCOCNU2 = "OCOCNU2";

        /// <summary>
        /// OCOCNU3.
        /// </summary>
        public const string OCOCNU3 = "OCOCNU3";

        /// <summary>
        /// OCPID.
        /// </summary>
        public const string OCPID = "OCPID";

        /// <summary>
        /// OCUSER.
        /// </summary>
        public const string OCUSER = "OCUSER";

        /// <summary>
        /// OCUPMJ.
        /// </summary>
        public const string OCUPMJ = "OCUPMJ";

        /// <summary>
        /// OCUPMT.
        /// </summary>
        public const string OCUPMT = "OCUPMT";

        /// <summary>
        /// OCJOBN.
        /// </summary>
        public const string OCJOBN = "OCJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F09302";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("OCSY", "OCSY", JdeDataType.String, 8, true, true),
        new JdeField("OCERDF", "OCERDF", JdeDataType.String, 2),
        new JdeField("OCECDF", "OCECDF", JdeDataType.String, 2),
        new JdeField("OCOCCT1", "OCOCCT1", JdeDataType.String, 2),
        new JdeField("OCOCCT2", "OCOCCT2", JdeDataType.String, 2),
        new JdeField("OCOCCT3", "OCOCCT3", JdeDataType.String, 2),
        new JdeField("OCOCCT4", "OCOCCT4", JdeDataType.String, 2),
        new JdeField("OCOCCT5", "OCOCCT5", JdeDataType.String, 2),
        new JdeField("OCOCCT6", "OCOCCT6", JdeDataType.String, 2),
        new JdeField("OCOCST1", "OCOCST1", JdeDataType.String, 160),
        new JdeField("OCOCST2", "OCOCST2", JdeDataType.String, 160),
        new JdeField("OCOCST3", "OCOCST3", JdeDataType.String, 160),
        new JdeField("OCOCDT1", "OCOCDT1", JdeDataType.Numeric),
        new JdeField("OCOCDT2", "OCOCDT2", JdeDataType.Numeric),
        new JdeField("OCOCDT3", "OCOCDT3", JdeDataType.Numeric),
        new JdeField("OCOCNU1", "OCOCNU1", JdeDataType.Numeric),
        new JdeField("OCOCNU2", "OCOCNU2", JdeDataType.Numeric),
        new JdeField("OCOCNU3", "OCOCNU3", JdeDataType.Numeric),
        new JdeField("OCPID", "OCPID", JdeDataType.String, 20),
        new JdeField("OCUSER", "OCUSER", JdeDataType.String, 20),
        new JdeField("OCUPMJ", "OCUPMJ", JdeDataType.Numeric),
        new JdeField("OCUPMT", "OCUPMT", JdeDataType.Numeric),
        new JdeField("OCJOBN", "OCJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F09302_0", "Primary Key on OCSY", new[] { "OCSY" }, isUnique: true, isPrimaryKey: true)
    };
}
