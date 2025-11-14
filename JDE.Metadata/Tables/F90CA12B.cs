using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F90CA12B - .
/// </summary>
public class F90CA12B : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// IBCIG.
        /// </summary>
        public const string IBCIG = "IBCIG";

        /// <summary>
        /// IBEMAN8.
        /// </summary>
        public const string IBEMAN8 = "IBEMAN8";

        /// <summary>
        /// IBSRLNMBR.
        /// </summary>
        public const string IBSRLNMBR = "IBSRLNMBR";

        /// <summary>
        /// IBSTSUDT.
        /// </summary>
        public const string IBSTSUDT = "IBSTSUDT";

        /// <summary>
        /// IBACTIND.
        /// </summary>
        public const string IBACTIND = "IBACTIND";

        /// <summary>
        /// IBSTMBDT.
        /// </summary>
        public const string IBSTMBDT = "IBSTMBDT";

        /// <summary>
        /// IBSTMEDT.
        /// </summary>
        public const string IBSTMEDT = "IBSTMEDT";

        /// <summary>
        /// IBUSER.
        /// </summary>
        public const string IBUSER = "IBUSER";

        /// <summary>
        /// IBPID.
        /// </summary>
        public const string IBPID = "IBPID";

        /// <summary>
        /// IBVID.
        /// </summary>
        public const string IBVID = "IBVID";

        /// <summary>
        /// IBMKEY.
        /// </summary>
        public const string IBMKEY = "IBMKEY";

        /// <summary>
        /// IBUDTTM.
        /// </summary>
        public const string IBUDTTM = "IBUDTTM";

        /// <summary>
        /// IBEDATE.
        /// </summary>
        public const string IBEDATE = "IBEDATE";

        /// <summary>
        /// IBENTDBY.
        /// </summary>
        public const string IBENTDBY = "IBENTDBY";
    }

    /// <inheritdoc />
    public override string TableName => "F90CA12B";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("IBCIG", "IBCIG", JdeDataType.Numeric, null, true, true),
        new JdeField("IBEMAN8", "IBEMAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("IBSRLNMBR", "IBSRLNMBR", JdeDataType.Numeric, null, true, true),
        new JdeField("IBSTSUDT", "IBSTSUDT", JdeDataType.Date),
        new JdeField("IBACTIND", "IBACTIND", JdeDataType.String, 2),
        new JdeField("IBSTMBDT", "IBSTMBDT", JdeDataType.Date),
        new JdeField("IBSTMEDT", "IBSTMEDT", JdeDataType.Date),
        new JdeField("IBUSER", "IBUSER", JdeDataType.String, 20),
        new JdeField("IBPID", "IBPID", JdeDataType.String, 20),
        new JdeField("IBVID", "IBVID", JdeDataType.String, 20),
        new JdeField("IBMKEY", "IBMKEY", JdeDataType.String, 30),
        new JdeField("IBUDTTM", "IBUDTTM", JdeDataType.Date),
        new JdeField("IBEDATE", "IBEDATE", JdeDataType.Date),
        new JdeField("IBENTDBY", "IBENTDBY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F90CA12B_0", "Primary Key on IBCIG, IBEMAN8, IBSRLNMBR", new[] { "IBCIG", "IBEMAN8", "IBSRLNMBR" }, isUnique: true, isPrimaryKey: true)
    };
}
