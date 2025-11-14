using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F0008B - .
/// </summary>
public class F0008B : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CDDTPN.
        /// </summary>
        public const string CDDTPN = "CDDTPN";

        /// <summary>
        /// CDDFYJ.
        /// </summary>
        public const string CDDFYJ = "CDDFYJ";

        /// <summary>
        /// CDFQ.
        /// </summary>
        public const string CDFQ = "CDFQ";

        /// <summary>
        /// CDD01J.
        /// </summary>
        public const string CDD01J = "CDD01J";

        /// <summary>
        /// CDD02J.
        /// </summary>
        public const string CDD02J = "CDD02J";

        /// <summary>
        /// CDD03J.
        /// </summary>
        public const string CDD03J = "CDD03J";

        /// <summary>
        /// CDD04J.
        /// </summary>
        public const string CDD04J = "CDD04J";

        /// <summary>
        /// CDD05J.
        /// </summary>
        public const string CDD05J = "CDD05J";

        /// <summary>
        /// CDD06J.
        /// </summary>
        public const string CDD06J = "CDD06J";

        /// <summary>
        /// CDD07J.
        /// </summary>
        public const string CDD07J = "CDD07J";

        /// <summary>
        /// CDD08J.
        /// </summary>
        public const string CDD08J = "CDD08J";

        /// <summary>
        /// CDD09J.
        /// </summary>
        public const string CDD09J = "CDD09J";

        /// <summary>
        /// CDD10J.
        /// </summary>
        public const string CDD10J = "CDD10J";

        /// <summary>
        /// CDD11J.
        /// </summary>
        public const string CDD11J = "CDD11J";

        /// <summary>
        /// CDD12J.
        /// </summary>
        public const string CDD12J = "CDD12J";

        /// <summary>
        /// CDD13J.
        /// </summary>
        public const string CDD13J = "CDD13J";

        /// <summary>
        /// CDD14J.
        /// </summary>
        public const string CDD14J = "CDD14J";

        /// <summary>
        /// CDD15J.
        /// </summary>
        public const string CDD15J = "CDD15J";

        /// <summary>
        /// CDD16J.
        /// </summary>
        public const string CDD16J = "CDD16J";

        /// <summary>
        /// CDD17J.
        /// </summary>
        public const string CDD17J = "CDD17J";

        /// <summary>
        /// CDD18J.
        /// </summary>
        public const string CDD18J = "CDD18J";

        /// <summary>
        /// CDD19J.
        /// </summary>
        public const string CDD19J = "CDD19J";

        /// <summary>
        /// CDD20J.
        /// </summary>
        public const string CDD20J = "CDD20J";

        /// <summary>
        /// CDD21J.
        /// </summary>
        public const string CDD21J = "CDD21J";

        /// <summary>
        /// CDD22J.
        /// </summary>
        public const string CDD22J = "CDD22J";

        /// <summary>
        /// CDD23J.
        /// </summary>
        public const string CDD23J = "CDD23J";

        /// <summary>
        /// CDD24J.
        /// </summary>
        public const string CDD24J = "CDD24J";

        /// <summary>
        /// CDD25J.
        /// </summary>
        public const string CDD25J = "CDD25J";

        /// <summary>
        /// CDD26J.
        /// </summary>
        public const string CDD26J = "CDD26J";

        /// <summary>
        /// CDD27J.
        /// </summary>
        public const string CDD27J = "CDD27J";

        /// <summary>
        /// CDD28J.
        /// </summary>
        public const string CDD28J = "CDD28J";

        /// <summary>
        /// CDD29J.
        /// </summary>
        public const string CDD29J = "CDD29J";

        /// <summary>
        /// CDD30J.
        /// </summary>
        public const string CDD30J = "CDD30J";

        /// <summary>
        /// CDD31J.
        /// </summary>
        public const string CDD31J = "CDD31J";

        /// <summary>
        /// CDD32J.
        /// </summary>
        public const string CDD32J = "CDD32J";

        /// <summary>
        /// CDD33J.
        /// </summary>
        public const string CDD33J = "CDD33J";

        /// <summary>
        /// CDD34J.
        /// </summary>
        public const string CDD34J = "CDD34J";

        /// <summary>
        /// CDD35J.
        /// </summary>
        public const string CDD35J = "CDD35J";

        /// <summary>
        /// CDD36J.
        /// </summary>
        public const string CDD36J = "CDD36J";

        /// <summary>
        /// CDD37J.
        /// </summary>
        public const string CDD37J = "CDD37J";

        /// <summary>
        /// CDD38J.
        /// </summary>
        public const string CDD38J = "CDD38J";

        /// <summary>
        /// CDD39J.
        /// </summary>
        public const string CDD39J = "CDD39J";

        /// <summary>
        /// CDD40J.
        /// </summary>
        public const string CDD40J = "CDD40J";

        /// <summary>
        /// CDD41J.
        /// </summary>
        public const string CDD41J = "CDD41J";

        /// <summary>
        /// CDD42J.
        /// </summary>
        public const string CDD42J = "CDD42J";

        /// <summary>
        /// CDD43J.
        /// </summary>
        public const string CDD43J = "CDD43J";

        /// <summary>
        /// CDD44J.
        /// </summary>
        public const string CDD44J = "CDD44J";

        /// <summary>
        /// CDD45J.
        /// </summary>
        public const string CDD45J = "CDD45J";

        /// <summary>
        /// CDD46J.
        /// </summary>
        public const string CDD46J = "CDD46J";

        /// <summary>
        /// CDD47J.
        /// </summary>
        public const string CDD47J = "CDD47J";

        /// <summary>
        /// CDD48J.
        /// </summary>
        public const string CDD48J = "CDD48J";

        /// <summary>
        /// CDD49J.
        /// </summary>
        public const string CDD49J = "CDD49J";

        /// <summary>
        /// CDD50J.
        /// </summary>
        public const string CDD50J = "CDD50J";

        /// <summary>
        /// CDD51J.
        /// </summary>
        public const string CDD51J = "CDD51J";

        /// <summary>
        /// CDD52J.
        /// </summary>
        public const string CDD52J = "CDD52J";

        /// <summary>
        /// CDD53J.
        /// </summary>
        public const string CDD53J = "CDD53J";

        /// <summary>
        /// CDD54J.
        /// </summary>
        public const string CDD54J = "CDD54J";

        /// <summary>
        /// CDPNT.
        /// </summary>
        public const string CDPNT = "CDPNT";

        /// <summary>
        /// CDUSER.
        /// </summary>
        public const string CDUSER = "CDUSER";

        /// <summary>
        /// CDPID.
        /// </summary>
        public const string CDPID = "CDPID";

        /// <summary>
        /// CDUPMJ.
        /// </summary>
        public const string CDUPMJ = "CDUPMJ";

        /// <summary>
        /// CDJOBN.
        /// </summary>
        public const string CDJOBN = "CDJOBN";

        /// <summary>
        /// CDUPMT.
        /// </summary>
        public const string CDUPMT = "CDUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F0008B";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CDDTPN", "CDDTPN", JdeDataType.String, 2, true, true),
        new JdeField("CDDFYJ", "CDDFYJ", JdeDataType.Numeric, null, true, true),
        new JdeField("CDFQ", "CDFQ", JdeDataType.String, 8, true, true),
        new JdeField("CDD01J", "CDD01J", JdeDataType.Numeric),
        new JdeField("CDD02J", "CDD02J", JdeDataType.Numeric),
        new JdeField("CDD03J", "CDD03J", JdeDataType.Numeric),
        new JdeField("CDD04J", "CDD04J", JdeDataType.Numeric),
        new JdeField("CDD05J", "CDD05J", JdeDataType.Numeric),
        new JdeField("CDD06J", "CDD06J", JdeDataType.Numeric),
        new JdeField("CDD07J", "CDD07J", JdeDataType.Numeric),
        new JdeField("CDD08J", "CDD08J", JdeDataType.Numeric),
        new JdeField("CDD09J", "CDD09J", JdeDataType.Numeric),
        new JdeField("CDD10J", "CDD10J", JdeDataType.Numeric),
        new JdeField("CDD11J", "CDD11J", JdeDataType.Numeric),
        new JdeField("CDD12J", "CDD12J", JdeDataType.Numeric),
        new JdeField("CDD13J", "CDD13J", JdeDataType.Numeric),
        new JdeField("CDD14J", "CDD14J", JdeDataType.Numeric),
        new JdeField("CDD15J", "CDD15J", JdeDataType.Numeric),
        new JdeField("CDD16J", "CDD16J", JdeDataType.Numeric),
        new JdeField("CDD17J", "CDD17J", JdeDataType.Numeric),
        new JdeField("CDD18J", "CDD18J", JdeDataType.Numeric),
        new JdeField("CDD19J", "CDD19J", JdeDataType.Numeric),
        new JdeField("CDD20J", "CDD20J", JdeDataType.Numeric),
        new JdeField("CDD21J", "CDD21J", JdeDataType.Numeric),
        new JdeField("CDD22J", "CDD22J", JdeDataType.Numeric),
        new JdeField("CDD23J", "CDD23J", JdeDataType.Numeric),
        new JdeField("CDD24J", "CDD24J", JdeDataType.Numeric),
        new JdeField("CDD25J", "CDD25J", JdeDataType.Numeric),
        new JdeField("CDD26J", "CDD26J", JdeDataType.Numeric),
        new JdeField("CDD27J", "CDD27J", JdeDataType.Numeric),
        new JdeField("CDD28J", "CDD28J", JdeDataType.Numeric),
        new JdeField("CDD29J", "CDD29J", JdeDataType.Numeric),
        new JdeField("CDD30J", "CDD30J", JdeDataType.Numeric),
        new JdeField("CDD31J", "CDD31J", JdeDataType.Numeric),
        new JdeField("CDD32J", "CDD32J", JdeDataType.Numeric),
        new JdeField("CDD33J", "CDD33J", JdeDataType.Numeric),
        new JdeField("CDD34J", "CDD34J", JdeDataType.Numeric),
        new JdeField("CDD35J", "CDD35J", JdeDataType.Numeric),
        new JdeField("CDD36J", "CDD36J", JdeDataType.Numeric),
        new JdeField("CDD37J", "CDD37J", JdeDataType.Numeric),
        new JdeField("CDD38J", "CDD38J", JdeDataType.Numeric),
        new JdeField("CDD39J", "CDD39J", JdeDataType.Numeric),
        new JdeField("CDD40J", "CDD40J", JdeDataType.Numeric),
        new JdeField("CDD41J", "CDD41J", JdeDataType.Numeric),
        new JdeField("CDD42J", "CDD42J", JdeDataType.Numeric),
        new JdeField("CDD43J", "CDD43J", JdeDataType.Numeric),
        new JdeField("CDD44J", "CDD44J", JdeDataType.Numeric),
        new JdeField("CDD45J", "CDD45J", JdeDataType.Numeric),
        new JdeField("CDD46J", "CDD46J", JdeDataType.Numeric),
        new JdeField("CDD47J", "CDD47J", JdeDataType.Numeric),
        new JdeField("CDD48J", "CDD48J", JdeDataType.Numeric),
        new JdeField("CDD49J", "CDD49J", JdeDataType.Numeric),
        new JdeField("CDD50J", "CDD50J", JdeDataType.Numeric),
        new JdeField("CDD51J", "CDD51J", JdeDataType.Numeric),
        new JdeField("CDD52J", "CDD52J", JdeDataType.Numeric),
        new JdeField("CDD53J", "CDD53J", JdeDataType.Numeric),
        new JdeField("CDD54J", "CDD54J", JdeDataType.Numeric),
        new JdeField("CDPNT", "CDPNT", JdeDataType.String, 2),
        new JdeField("CDUSER", "CDUSER", JdeDataType.String, 20),
        new JdeField("CDPID", "CDPID", JdeDataType.String, 20),
        new JdeField("CDUPMJ", "CDUPMJ", JdeDataType.Numeric),
        new JdeField("CDJOBN", "CDJOBN", JdeDataType.String, 20),
        new JdeField("CDUPMT", "CDUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F0008B_0", "Primary Key on CDDTPN, CDDFYJ, CDFQ", new[] { "CDDTPN", "CDDFYJ", "CDFQ" }, isUnique: true, isPrimaryKey: true)
    };
}
