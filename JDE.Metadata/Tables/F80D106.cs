using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F80D106 - .
/// </summary>
public class F80D106 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PLPLISTID.
        /// </summary>
        public const string PLPLISTID = "PLPLISTID";

        /// <summary>
        /// PLPRP4.
        /// </summary>
        public const string PLPRP4 = "PLPRP4";

        /// <summary>
        /// PLURCD.
        /// </summary>
        public const string PLURCD = "PLURCD";

        /// <summary>
        /// PLURDT.
        /// </summary>
        public const string PLURDT = "PLURDT";

        /// <summary>
        /// PLURAT.
        /// </summary>
        public const string PLURAT = "PLURAT";

        /// <summary>
        /// PLURAB.
        /// </summary>
        public const string PLURAB = "PLURAB";

        /// <summary>
        /// PLURRF.
        /// </summary>
        public const string PLURRF = "PLURRF";

        /// <summary>
        /// PLUSER.
        /// </summary>
        public const string PLUSER = "PLUSER";

        /// <summary>
        /// PLMKEY.
        /// </summary>
        public const string PLMKEY = "PLMKEY";

        /// <summary>
        /// PLPID.
        /// </summary>
        public const string PLPID = "PLPID";

        /// <summary>
        /// PLUUPMJ.
        /// </summary>
        public const string PLUUPMJ = "PLUUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "F80D106";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PLPLISTID", "PLPLISTID", JdeDataType.String, 24, true, true),
        new JdeField("PLPRP4", "PLPRP4", JdeDataType.String, 6, true, true),
        new JdeField("PLURCD", "PLURCD", JdeDataType.String, 4),
        new JdeField("PLURDT", "PLURDT", JdeDataType.Numeric),
        new JdeField("PLURAT", "PLURAT", JdeDataType.Numeric),
        new JdeField("PLURAB", "PLURAB", JdeDataType.Numeric),
        new JdeField("PLURRF", "PLURRF", JdeDataType.String, 30),
        new JdeField("PLUSER", "PLUSER", JdeDataType.String, 20),
        new JdeField("PLMKEY", "PLMKEY", JdeDataType.String, 30),
        new JdeField("PLPID", "PLPID", JdeDataType.String, 20),
        new JdeField("PLUUPMJ", "PLUUPMJ", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F80D106_0", "Primary Key on PLPLISTID, PLPRP4", new[] { "PLPLISTID", "PLPRP4" }, isUnique: true, isPrimaryKey: true)
    };
}
