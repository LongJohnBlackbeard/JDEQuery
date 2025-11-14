using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F31B40 - .
/// </summary>
public class F31B40 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SASATUID.
        /// </summary>
        public const string SASATUID = "SASATUID";

        /// <summary>
        /// SASADATYP.
        /// </summary>
        public const string SASADATYP = "SASADATYP";

        /// <summary>
        /// SASATDES.
        /// </summary>
        public const string SASATDES = "SASATDES";

        /// <summary>
        /// SASAFNTYP.
        /// </summary>
        public const string SASAFNTYP = "SASAFNTYP";

        /// <summary>
        /// SASATENT.
        /// </summary>
        public const string SASATENT = "SASATENT";

        /// <summary>
        /// SASARTFLD.
        /// </summary>
        public const string SASARTFLD = "SASARTFLD";

        /// <summary>
        /// SASAFNNAM.
        /// </summary>
        public const string SASAFNNAM = "SASAFNNAM";

        /// <summary>
        /// SASASLFLD.
        /// </summary>
        public const string SASASLFLD = "SASASLFLD";

        /// <summary>
        /// SASASLVAL.
        /// </summary>
        public const string SASASLVAL = "SASASLVAL";

        /// <summary>
        /// SASASLRUL.
        /// </summary>
        public const string SASASLRUL = "SASASLRUL";

        /// <summary>
        /// SASATTHR.
        /// </summary>
        public const string SASATTHR = "SASATTHR";

        /// <summary>
        /// SASASTAT.
        /// </summary>
        public const string SASASTAT = "SASASTAT";

        /// <summary>
        /// SAUSER.
        /// </summary>
        public const string SAUSER = "SAUSER";

        /// <summary>
        /// SAPID.
        /// </summary>
        public const string SAPID = "SAPID";

        /// <summary>
        /// SAJOBN.
        /// </summary>
        public const string SAJOBN = "SAJOBN";

        /// <summary>
        /// SAUPMJ.
        /// </summary>
        public const string SAUPMJ = "SAUPMJ";

        /// <summary>
        /// SAUPMT.
        /// </summary>
        public const string SAUPMT = "SAUPMT";

        /// <summary>
        /// SAURCD.
        /// </summary>
        public const string SAURCD = "SAURCD";

        /// <summary>
        /// SAURDT.
        /// </summary>
        public const string SAURDT = "SAURDT";

        /// <summary>
        /// SAURAT.
        /// </summary>
        public const string SAURAT = "SAURAT";

        /// <summary>
        /// SAURRF.
        /// </summary>
        public const string SAURRF = "SAURRF";

        /// <summary>
        /// SAURAB.
        /// </summary>
        public const string SAURAB = "SAURAB";
    }

    /// <inheritdoc />
    public override string TableName => "F31B40";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SASATUID", "SASATUID", JdeDataType.Numeric, null, true, true),
        new JdeField("SASADATYP", "SASADATYP", JdeDataType.String, 20),
        new JdeField("SASATDES", "SASATDES", JdeDataType.String, 60),
        new JdeField("SASAFNTYP", "SASAFNTYP", JdeDataType.String, 2),
        new JdeField("SASATENT", "SASATENT", JdeDataType.String, 4),
        new JdeField("SASARTFLD", "SASARTFLD", JdeDataType.String, 60),
        new JdeField("SASAFNNAM", "SASAFNNAM", JdeDataType.String, 60),
        new JdeField("SASASLFLD", "SASASLFLD", JdeDataType.String, 60),
        new JdeField("SASASLVAL", "SASASLVAL", JdeDataType.String, 30),
        new JdeField("SASASLRUL", "SASASLRUL", JdeDataType.String, 60),
        new JdeField("SASATTHR", "SASATTHR", JdeDataType.Numeric),
        new JdeField("SASASTAT", "SASASTAT", JdeDataType.String, 2),
        new JdeField("SAUSER", "SAUSER", JdeDataType.String, 20),
        new JdeField("SAPID", "SAPID", JdeDataType.String, 20),
        new JdeField("SAJOBN", "SAJOBN", JdeDataType.String, 20),
        new JdeField("SAUPMJ", "SAUPMJ", JdeDataType.Numeric),
        new JdeField("SAUPMT", "SAUPMT", JdeDataType.Numeric),
        new JdeField("SAURCD", "SAURCD", JdeDataType.String, 4),
        new JdeField("SAURDT", "SAURDT", JdeDataType.Numeric),
        new JdeField("SAURAT", "SAURAT", JdeDataType.Numeric),
        new JdeField("SAURRF", "SAURRF", JdeDataType.String, 30),
        new JdeField("SAURAB", "SAURAB", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F31B40_0", "Primary Key on SASATUID", new[] { "SASATUID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F31B40_2", "Index on SASASTAT", new[] { "SASASTAT" })
    };
}
