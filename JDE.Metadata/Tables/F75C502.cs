using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75C502 - .
/// </summary>
public class F75C502 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PPPPY.
        /// </summary>
        public const string PPPPY = "PPPPY";

        /// <summary>
        /// PPPPM.
        /// </summary>
        public const string PPPPM = "PPPPM";

        /// <summary>
        /// PPC75PPSDT.
        /// </summary>
        public const string PPC75PPSDT = "PPC75PPSDT";

        /// <summary>
        /// PPC75PPEDT.
        /// </summary>
        public const string PPC75PPEDT = "PPC75PPEDT";

        /// <summary>
        /// PPC75ACCPD.
        /// </summary>
        public const string PPC75ACCPD = "PPC75ACCPD";

        /// <summary>
        /// PPC75ACCYR.
        /// </summary>
        public const string PPC75ACCYR = "PPC75ACCYR";

        /// <summary>
        /// PPFUTMATH1.
        /// </summary>
        public const string PPFUTMATH1 = "PPFUTMATH1";

        /// <summary>
        /// PPFUTSTR1.
        /// </summary>
        public const string PPFUTSTR1 = "PPFUTSTR1";

        /// <summary>
        /// PPFUTSTR2.
        /// </summary>
        public const string PPFUTSTR2 = "PPFUTSTR2";

        /// <summary>
        /// PPFUTDATE1.
        /// </summary>
        public const string PPFUTDATE1 = "PPFUTDATE1";

        /// <summary>
        /// PPFUTUO1.
        /// </summary>
        public const string PPFUTUO1 = "PPFUTUO1";

        /// <summary>
        /// PPUSER.
        /// </summary>
        public const string PPUSER = "PPUSER";

        /// <summary>
        /// PPPID.
        /// </summary>
        public const string PPPID = "PPPID";

        /// <summary>
        /// PPJOBN.
        /// </summary>
        public const string PPJOBN = "PPJOBN";

        /// <summary>
        /// PPUPMJ.
        /// </summary>
        public const string PPUPMJ = "PPUPMJ";

        /// <summary>
        /// PPUPMT.
        /// </summary>
        public const string PPUPMT = "PPUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F75C502";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PPPPY", "PPPPY", JdeDataType.Numeric, null, true, true),
        new JdeField("PPPPM", "PPPPM", JdeDataType.Numeric, null, true, true),
        new JdeField("PPC75PPSDT", "PPC75PPSDT", JdeDataType.Numeric),
        new JdeField("PPC75PPEDT", "PPC75PPEDT", JdeDataType.Numeric),
        new JdeField("PPC75ACCPD", "PPC75ACCPD", JdeDataType.Numeric),
        new JdeField("PPC75ACCYR", "PPC75ACCYR", JdeDataType.Numeric),
        new JdeField("PPFUTMATH1", "PPFUTMATH1", JdeDataType.Numeric),
        new JdeField("PPFUTSTR1", "PPFUTSTR1", JdeDataType.String, 100),
        new JdeField("PPFUTSTR2", "PPFUTSTR2", JdeDataType.String, 100),
        new JdeField("PPFUTDATE1", "PPFUTDATE1", JdeDataType.Numeric),
        new JdeField("PPFUTUO1", "PPFUTUO1", JdeDataType.String, 2),
        new JdeField("PPUSER", "PPUSER", JdeDataType.String, 20),
        new JdeField("PPPID", "PPPID", JdeDataType.String, 20),
        new JdeField("PPJOBN", "PPJOBN", JdeDataType.String, 20),
        new JdeField("PPUPMJ", "PPUPMJ", JdeDataType.Numeric),
        new JdeField("PPUPMT", "PPUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75C502_0", "Primary Key on PPPPY, PPPPM", new[] { "PPPPY", "PPPPM" }, isUnique: true, isPrimaryKey: true)
    };
}
