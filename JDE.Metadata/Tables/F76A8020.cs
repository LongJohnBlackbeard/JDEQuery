using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76A8020 - .
/// </summary>
public class F76A8020 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// EPAN8.
        /// </summary>
        public const string EPAN8 = "EPAN8";

        /// <summary>
        /// EPDCT.
        /// </summary>
        public const string EPDCT = "EPDCT";

        /// <summary>
        /// EPEFTJ.
        /// </summary>
        public const string EPEFTJ = "EPEFTJ";

        /// <summary>
        /// EPA009.
        /// </summary>
        public const string EPA009 = "EPA009";

        /// <summary>
        /// EPAPR1.
        /// </summary>
        public const string EPAPR1 = "EPAPR1";

        /// <summary>
        /// EPEFDJ.
        /// </summary>
        public const string EPEFDJ = "EPEFDJ";

        /// <summary>
        /// EPABD.
        /// </summary>
        public const string EPABD = "EPABD";

        /// <summary>
        /// EPPID.
        /// </summary>
        public const string EPPID = "EPPID";

        /// <summary>
        /// EPUSER.
        /// </summary>
        public const string EPUSER = "EPUSER";

        /// <summary>
        /// EPJOBN.
        /// </summary>
        public const string EPJOBN = "EPJOBN";

        /// <summary>
        /// EPUPMJ.
        /// </summary>
        public const string EPUPMJ = "EPUPMJ";

        /// <summary>
        /// EPTDAY.
        /// </summary>
        public const string EPTDAY = "EPTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F76A8020";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("EPAN8", "EPAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("EPDCT", "EPDCT", JdeDataType.String, 4, true, true),
        new JdeField("EPEFTJ", "EPEFTJ", JdeDataType.Numeric, null, true, true),
        new JdeField("EPA009", "EPA009", JdeDataType.String, 6, true, true),
        new JdeField("EPAPR1", "EPAPR1", JdeDataType.Numeric),
        new JdeField("EPEFDJ", "EPEFDJ", JdeDataType.Numeric),
        new JdeField("EPABD", "EPABD", JdeDataType.Numeric),
        new JdeField("EPPID", "EPPID", JdeDataType.String, 20),
        new JdeField("EPUSER", "EPUSER", JdeDataType.String, 20),
        new JdeField("EPJOBN", "EPJOBN", JdeDataType.String, 20),
        new JdeField("EPUPMJ", "EPUPMJ", JdeDataType.Numeric),
        new JdeField("EPTDAY", "EPTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76A8020_0", "Primary Key on EPAN8, EPDCT, EPEFTJ, EPA009", new[] { "EPAN8", "EPDCT", "EPEFTJ", "EPA009" }, isUnique: true, isPrimaryKey: true)
    };
}
