using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FCW41 - .
/// </summary>
public class FCW41 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CRC9CMR.
        /// </summary>
        public const string CRC9CMR = "CRC9CMR";

        /// <summary>
        /// CRC9ALIAS1.
        /// </summary>
        public const string CRC9ALIAS1 = "CRC9ALIAS1";

        /// <summary>
        /// CRC9PRIO1.
        /// </summary>
        public const string CRC9PRIO1 = "CRC9PRIO1";

        /// <summary>
        /// CRC9ALIAS2.
        /// </summary>
        public const string CRC9ALIAS2 = "CRC9ALIAS2";

        /// <summary>
        /// CRC9PRIO2.
        /// </summary>
        public const string CRC9PRIO2 = "CRC9PRIO2";

        /// <summary>
        /// CRC9ALIAS3.
        /// </summary>
        public const string CRC9ALIAS3 = "CRC9ALIAS3";

        /// <summary>
        /// CRC9PRIO3.
        /// </summary>
        public const string CRC9PRIO3 = "CRC9PRIO3";

        /// <summary>
        /// CRC9ALIAS4.
        /// </summary>
        public const string CRC9ALIAS4 = "CRC9ALIAS4";

        /// <summary>
        /// CRC9PRIO4.
        /// </summary>
        public const string CRC9PRIO4 = "CRC9PRIO4";

        /// <summary>
        /// CRC9ALIAS5.
        /// </summary>
        public const string CRC9ALIAS5 = "CRC9ALIAS5";

        /// <summary>
        /// CRC9PRIO5.
        /// </summary>
        public const string CRC9PRIO5 = "CRC9PRIO5";

        /// <summary>
        /// CRC9PRIO6.
        /// </summary>
        public const string CRC9PRIO6 = "CRC9PRIO6";

        /// <summary>
        /// CRC9PRIO7.
        /// </summary>
        public const string CRC9PRIO7 = "CRC9PRIO7";

        /// <summary>
        /// CRC9PRIO8.
        /// </summary>
        public const string CRC9PRIO8 = "CRC9PRIO8";

        /// <summary>
        /// CRC9PRIO9.
        /// </summary>
        public const string CRC9PRIO9 = "CRC9PRIO9";

        /// <summary>
        /// CRC9ALIAS6.
        /// </summary>
        public const string CRC9ALIAS6 = "CRC9ALIAS6";

        /// <summary>
        /// CRC9PRIO10.
        /// </summary>
        public const string CRC9PRIO10 = "CRC9PRIO10";

        /// <summary>
        /// CRC9ALIAS7.
        /// </summary>
        public const string CRC9ALIAS7 = "CRC9ALIAS7";

        /// <summary>
        /// CRC9PRIO11.
        /// </summary>
        public const string CRC9PRIO11 = "CRC9PRIO11";

        /// <summary>
        /// CRC9PRIO12.
        /// </summary>
        public const string CRC9PRIO12 = "CRC9PRIO12";

        /// <summary>
        /// CRC9PRIO13.
        /// </summary>
        public const string CRC9PRIO13 = "CRC9PRIO13";

        /// <summary>
        /// CRUSER.
        /// </summary>
        public const string CRUSER = "CRUSER";

        /// <summary>
        /// CRPID.
        /// </summary>
        public const string CRPID = "CRPID";

        /// <summary>
        /// CRJOBN.
        /// </summary>
        public const string CRJOBN = "CRJOBN";

        /// <summary>
        /// CRUPMJ.
        /// </summary>
        public const string CRUPMJ = "CRUPMJ";

        /// <summary>
        /// CRTDAY.
        /// </summary>
        public const string CRTDAY = "CRTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "FCW41";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CRC9CMR", "CRC9CMR", JdeDataType.String, 20, true, true),
        new JdeField("CRC9ALIAS1", "CRC9ALIAS1", JdeDataType.String, 20),
        new JdeField("CRC9PRIO1", "CRC9PRIO1", JdeDataType.Numeric),
        new JdeField("CRC9ALIAS2", "CRC9ALIAS2", JdeDataType.String, 20),
        new JdeField("CRC9PRIO2", "CRC9PRIO2", JdeDataType.Numeric),
        new JdeField("CRC9ALIAS3", "CRC9ALIAS3", JdeDataType.String, 20),
        new JdeField("CRC9PRIO3", "CRC9PRIO3", JdeDataType.Numeric),
        new JdeField("CRC9ALIAS4", "CRC9ALIAS4", JdeDataType.String, 20),
        new JdeField("CRC9PRIO4", "CRC9PRIO4", JdeDataType.Numeric),
        new JdeField("CRC9ALIAS5", "CRC9ALIAS5", JdeDataType.String, 20),
        new JdeField("CRC9PRIO5", "CRC9PRIO5", JdeDataType.Numeric),
        new JdeField("CRC9PRIO6", "CRC9PRIO6", JdeDataType.Numeric),
        new JdeField("CRC9PRIO7", "CRC9PRIO7", JdeDataType.Numeric),
        new JdeField("CRC9PRIO8", "CRC9PRIO8", JdeDataType.Numeric),
        new JdeField("CRC9PRIO9", "CRC9PRIO9", JdeDataType.Numeric),
        new JdeField("CRC9ALIAS6", "CRC9ALIAS6", JdeDataType.String, 20),
        new JdeField("CRC9PRIO10", "CRC9PRIO10", JdeDataType.Numeric),
        new JdeField("CRC9ALIAS7", "CRC9ALIAS7", JdeDataType.String, 20),
        new JdeField("CRC9PRIO11", "CRC9PRIO11", JdeDataType.Numeric),
        new JdeField("CRC9PRIO12", "CRC9PRIO12", JdeDataType.Numeric),
        new JdeField("CRC9PRIO13", "CRC9PRIO13", JdeDataType.Numeric),
        new JdeField("CRUSER", "CRUSER", JdeDataType.String, 20),
        new JdeField("CRPID", "CRPID", JdeDataType.String, 20),
        new JdeField("CRJOBN", "CRJOBN", JdeDataType.String, 20),
        new JdeField("CRUPMJ", "CRUPMJ", JdeDataType.Numeric),
        new JdeField("CRTDAY", "CRTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FCW41_0", "Primary Key on CRC9CMR", new[] { "CRC9CMR" }, isUnique: true, isPrimaryKey: true)
    };
}
